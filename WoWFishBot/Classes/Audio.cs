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
        /// <summary>
        /// Monitor audio level (non-stop)
        /// </summary>
        public static void MonitorCurrentVolume()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_MonitorCurrentVolume_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_MonitorCurrentVolume_ProgressChanged);
            bw.WorkerReportsProgress = true;
            bw.RunWorkerAsync();
        }

        private static void bw_MonitorCurrentVolume_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            while(true) 
            {
                worker.ReportProgress(GetCurrentMachineVolume());
                Util.Sleep(Config.audioTickRate);
            }
        }

        private static void bw_MonitorCurrentVolume_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int currentVolume = e.ProgressPercentage;
            Program.mainForm.UpdateCurrentVolume(currentVolume);
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

        private static int GetPeakVolumeOverTime(object sender, int seconds = 10)
        {
            List<int> volumeHistory = new List<int>();
            BackgroundWorker worker = (BackgroundWorker)sender;

            for (int i = 0; i < seconds*10; i++)
            {
                volumeHistory.Add(GetCurrentMachineVolume());
                worker.ReportProgress(volumeHistory.Max());
                Util.Sleep(100);
            }

            return volumeHistory.Max();
        }
    }
}
