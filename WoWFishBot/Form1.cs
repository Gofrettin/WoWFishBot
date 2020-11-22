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
            tb_Log.AppendText(message + Environment.NewLine);

            // auto scroll
            tb_Log.SelectionStart = tb_Log.Text.Length;
            tb_Log.ScrollToCaret();
        }

        public void UpdatePictureBox(Bitmap picture)
        {
            Logger.Log("Updating picture box");
            PictureBox.Image = picture;
        }

        public void UpdatePeakVolueControls(int percent)
        {
            PeakVolumeBar.Value = percent;
            PeakVolumeLable.Text = percent.ToString() + "%";
        }

        public void UpdateAllValues()
        {
            Logger.Log("Updating all UI values");
            Inp_TopLeft.Text = Config.topLeftCords.ToString();
            Inp_BottomRight.Text = Config.bottomRightCords.ToString();
            Inp_LureSkill.Text = Config.lureSkillCords.ToString();
            Inp_FishSkill.Text = Config.fishSkillCords.ToString();
            Inp_BobberColor.Text = Config.bobberColor.ToString();
            Inp_TriggerVolume.Value = Convert.ToInt32(Config.triggerVolumePercent);
            Inp_SleepChance.Value = Convert.ToInt32(Config.sleepChancePercent);
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

        private void Btn_CaptureAll_Click(object sender, EventArgs e) => Config.CaptureAll();
        private void Btn_CaptureTopLeft_Click(object sender, EventArgs e) => Config.CaptureTopLeft(3000);
        private void Btn_CaptureBottomRight_Click(object sender, EventArgs e) => Config.CaptureBottomRight(3000);
        private void Btn_CaptureLureSkill_Click(object sender, EventArgs e) => Config.CaptureLureSkill(3000);
        private void Btn_CaptureFishSkill_Click(object sender, EventArgs e) => Config.CaptureFishSkill(3000);
        private void Btn_CaptureBobberColor_Click(object sender, EventArgs e) => Config.CaptureBobberColor(3000);
        private void Btn_UpdateScreenshot_Click(object sender, EventArgs e) => Screen.CaptureScreen();
        private void Btn_GetVolume_Click(object sender, EventArgs e) => Audio.GetPeakVolume();
        private void Inp_SleepChance_ValueChanged(object sender, EventArgs e) => Config.sleepChancePercent = Convert.ToSingle(Inp_SleepChance.Value);
        private void Btn_SaveConfig_Click(object sender, EventArgs e) => Config.SaveConfig();
        private void Btn_ImportConfig_Click(object sender, EventArgs e) => Config.ImportConfig();
        private void Btn_Run_Click(object sender, EventArgs e) => Bot.Run();
    }
}
