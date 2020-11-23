using CSCore.XAudio2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWFishBot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // MODIFIERS
        public void UpdateStatusBar(string status)
        {
            StatusLabel.Text = status;
            StatusStrip.Update();
        }

        public void UpdateLog(string message)
        {
            if (tb_Log.Text.Length <= 0) tb_Log.Text = message;
            else tb_Log.AppendText(Environment.NewLine + message);

            // auto scroll
            tb_Log.SelectionStart = tb_Log.Text.Length;
            tb_Log.ScrollToCaret();
        }

        public void UpdatePictureBox(Bitmap picture)
        {
            Logger.Log("Updating picture box");
            PictureBox.Image = picture;

        }

        public void UpdateCurrentVolume(int currentVolume)
        {
            Bot.currentVolume = currentVolume;
            CurrentVolumeBar.Value = currentVolume;
            CurrentVolumeLabel.Text = $"{currentVolume}%";

            // update if new peak
            if (currentVolume > int.Parse(PeakVolumeLable.Text.Split('%')[0]))
                PeakVolumeLable.Text = currentVolume.ToString() + "%";
        }

        public void UpdateAllValues()
        {
            Logger.Log("Updating all UI values");
            Inp_TopLeft.Text = Config.topLeftCords.ToString();
            Inp_BottomRight.Text = Config.bottomRightCords.ToString();
            Inp_LureSkill.Text = Config.lureSkillCords.ToString();
            Inp_FishSkill.Text = Config.fishSkillCords.ToString();
            Inp_BobberColor.Text = $"RGB: {Config.bobberColor.R},{Config.bobberColor.G},{Config.bobberColor.B}";
            Inp_TriggerVolume.Value = Convert.ToInt32(Config.triggerVolumePercent);
            Inp_SleepChance.Value = Convert.ToInt32(Config.sleepChancePercent);
        }

        /// <summary>
        /// Sets the specified step (index 1 based)
        /// </summary>
        /// <param name="stepIndex"></param>
        public void UpdateStep(int stepIndex)
        {
            Logger.Log("Updating current step", Logger.Level.Trace, false);
            Listbox_CurrentStep.SelectedIndex = stepIndex - 1;
        }

        /// <summary>
        /// Goes to the next step (or first if no more)
        /// </summary>
        public void UpdateStep()
        {
            if (Listbox_CurrentStep.SelectedIndex < Listbox_CurrentStep.Items.Count)
                Listbox_CurrentStep.SelectedIndex++;
            else
                Listbox_CurrentStep.SelectedIndex = 0;
        }

        // EVENTS
        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {
            Lb_PickedVolume.Text = Inp_TriggerVolume.Value.ToString() + "%";
            Config.triggerVolumePercent = Inp_TriggerVolume.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Logger.Log("Updating settings");
            Config.sleepChancePercent = float.Parse(Inp_SleepChance.Text);

            UpdateStatusBar("Settings saved");
        }

        // Form load
        private void MainForm_Load(object sender, EventArgs e)
        {
            Config.ImportConfig();
            Audio.MonitorCurrentVolume();
        }

        // Form close
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Audio.StopAudioMonitor();
        }

        private void Btn_CaptureAll_Click(object sender, EventArgs e) => Config.CaptureAll();
        private void Btn_CaptureTopLeft_Click(object sender, EventArgs e) => Config.CaptureTopLeft();
        private void Btn_CaptureBottomRight_Click(object sender, EventArgs e) => Config.CaptureBottomRight();
        private void Btn_CaptureLureSkill_Click(object sender, EventArgs e) => Config.CaptureLureSkill();
        private void Btn_CaptureFishSkill_Click(object sender, EventArgs e) => Config.CaptureFishSkill();
        private void Btn_CaptureBobberColor_Click(object sender, EventArgs e) => Config.CaptureBobberColor();
        private void Btn_UpdateScreenshot_Click(object sender, EventArgs e) => Screen.CaptureScreen();
        private void Btn_ResetPeakVolume_Click(object sender, EventArgs e) => PeakVolumeLable.Text = "0%";
        private void Inp_SleepChance_ValueChanged(object sender, EventArgs e) => Config.sleepChancePercent = Convert.ToSingle(Inp_SleepChance.Value);
        private void Btn_SaveConfig_Click(object sender, EventArgs e) => Config.SaveConfig();
        private void Btn_ImportConfig_Click(object sender, EventArgs e) => Config.ImportConfig();
        private void Btn_Run_Click(object sender, EventArgs e) => Bot.Run();

        private void Btn_Stop_Click(object sender, EventArgs e) => Audio.StopAudioMonitor();
  
    }
}
