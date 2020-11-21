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
        // TODO: get X second peak


        public static void test()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.WorkerReportsProgress = true;

            Program.mainForm.UpdateStatusBar("Capturing peak volume...");
            bw.RunWorkerAsync();
        }

        private static void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = GetPeakVolumeOverTime(sender);
        }

        private static void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int peakVolume = e.ProgressPercentage;
            Program.mainForm.CurrentVolumeBar(peakVolume);
        }

        private static void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int peakVolume = (int)e.Result;
            Program.mainForm.CurrentVolumeBar(peakVolume);
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

        private static int GetCurrentVolume()
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
                volumeHistory.Add(GetCurrentVolume());
                worker.ReportProgress(volumeHistory.Max());
                Bot.Sleep(100);
            }

            return volumeHistory.Max();
        }
    }
}
