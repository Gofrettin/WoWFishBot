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
        public static void test()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync();
            
        }

        private static void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = GetCurrentVolume();
        }

        private static void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int currentVolume = (int)e.Result;
            Logger.Log($"Current Volume: {currentVolume}%");
            Program.mainForm.UpdateVolumeBar(currentVolume);
        }

        //AUDIO RELATED
        public static AudioSessionManager2 GetSoundSession(DataFlow dataFlow)
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

        public static int GetCurrentVolume()
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
