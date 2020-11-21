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

        // EVENTS

        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {
            Lb_PickedVolume.Text = VolumeBar.Value.ToString() + "%";
            Config.triggerVolumePercent = VolumeBar.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Logger.Log("Updating settings");
            Config.sleepChancePercent = float.Parse(Inp_SleepChance.Text);

            UpdateStatusBar("Settings saved");
        }

        private void Btn_CaptureAll_Click(object sender, EventArgs e) =>Config.CaptureAll();
        private void Btn_CaptureTopLeft_Click(object sender, EventArgs e) => Config.CaptureTopLeft(3000);
        private void Btn_CaptureBottomRight_Click(object sender, EventArgs e) => Config.CaptureBottomRight(3000);
        private void Btn_CaptureLureSkill_Click(object sender, EventArgs e) => Config.CaptureLureSkill(3000);
        private void Btn_CaptureFishSkill_Click(object sender, EventArgs e) => Config.CaptureFishSkill(3000);
        private void Btn_CaptureBobberColor_Click(object sender, EventArgs e) => Config.CaptureBobberColor(3000);
        private void Btn_UpdateScreenshot_Click(object sender, EventArgs e) => Screen.CaptureScreen();
        private void Btn_GetVolume_Click(object sender, EventArgs e) => Audio.GetPeakVolume();
        private void Btn_Run_Click(object sender, EventArgs e) => Bot.Run();
        private void Inp_SleepChance_ValueChanged(object sender, EventArgs e) => Config.sleepChancePercent = Convert.ToSingle(Inp_SleepChance.Value);

  
    }
}
