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
        public static void GetCurrentVolume()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_GetCurrentVolume_DoWork);
            bw.WorkerReportsProgress = true;
            bw.RunWorkerAsync();
        }
        private static void bw_GetCurrentVolume_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = GetCurrentMachineVolume();
            Bot.currentVolume = (int)e.Result;
        }

        public static void GetPeakVolume()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_GetPeakVolume_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_GetPeakVolume_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_GetPeakVolume_RunWorkerCompleted);
            bw.WorkerReportsProgress = true;
            bw.RunWorkerAsync();
        }

        private static void bw_GetPeakVolume_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = GetPeakVolumeOverTime(sender);
        }

        private static void bw_GetPeakVolume_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int peakVolume = e.ProgressPercentage;
            Program.mainForm.UpdatePeakVolueControls(peakVolume);
        }

        private static void bw_GetPeakVolume_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int peakVolume = (int)e.Result;
            Program.mainForm.UpdatePeakVolueControls(peakVolume);
            Program.mainForm.UpdateStatusBar($"Peak volume captured: {peakVolume}%");
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
