using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WoWFishBot
{
    class Audio
    {
        private static BackgroundWorker bw;

        /// <summary>
        /// Monitor audio level
        /// </summary>
        public static void StartAudioMonitor()
        {
            if (bw == null)
            {
                Logger.Log("Initilzing audio monitor thread");
                bw = new BackgroundWorker();
                bw.DoWork += new DoWorkEventHandler(bw_MonitorCurrentVolume_DoWork);
                bw.ProgressChanged += new ProgressChangedEventHandler(bw_MonitorCurrentVolume_ProgressChanged);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_MonitorCurrentVolume_Completed);
                bw.WorkerReportsProgress = true;
                bw.WorkerSupportsCancellation = true;
            }

            Logger.Log("Starting audio monitor");
            bw.RunWorkerAsync();
        }

        public static void StopAudioMonitor()
        {
            Logger.Log("Stopping audio monitor");
            bw.CancelAsync();
        }

        private static void bw_MonitorCurrentVolume_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            while(true) 
            {
                if (worker.CancellationPending)
                {
                    worker.ReportProgress(0);
                    break;
                } else
                {
                    worker.ReportProgress(GetCurrentMachineVolume());
                    Util.Sleep(Config.audioTickRate);
                }
            }
        }

        private static void bw_MonitorCurrentVolume_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int currentVolume = e.ProgressPercentage;
            Program.mainForm.UpdateCurrentVolume(currentVolume);
        }

        private static void bw_MonitorCurrentVolume_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        //AUDIO RELATED
        private static AudioSessionManager2 GetSoundSession(DataFlow dataFlow)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }

        private static int GetCurrentMachineVolume()
        {
            int currentVolume = 0;
            using (var sessionManager = GetSoundSession(DataFlow.Render))
            {
                using (var sessionEnumerator = sessionManager.GetSessionEnumerator())
                {
                    foreach (var session in sessionEnumerator)
                    {
                        using (var info = session.QueryInterface<AudioMeterInformation>())
                        {
                            currentVolume = Convert.ToInt32(info.GetPeakValue() * 100);
                            if (currentVolume > 0)
                                break;
                        }
                    }
                }
            }
            return currentVolume;
        }
    }
}
