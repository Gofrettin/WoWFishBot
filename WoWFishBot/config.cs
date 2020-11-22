using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WoWFishBot
{
    public static class Config
    {
        // CONFIG
        public static float triggerVolumePercent { get; set; }
        public static float sleepChancePercent { get; set; }
        public static float sleepMultiplier { get; set; }
        public static bool useLure { get; set; }
        public static Point topLeftCords { get; set; }
        public static Point bottomRightCords { get; set; }
        public static Point lureSkillCords { get; set; }
        public static Point fishSkillCords { get; set; }
        public static Color bobberColor { get; set; }

        /// <summary>
        /// Captures all settings
        /// </summary>
        public static void CaptureAll()
        {
            Logger.Log("Capturing settings");
            ClearAllCaptureInputs();

            // START CAPTURE PEAK VOLUME
            Audio.GetPeakVolume();

            // TOP LEFT
            Util.Sleep(1000);
            CaptureTopLeft();
            //Console.Beep();

            // BOTTOM RIGHT
            Util.Sleep(1000);
            CaptureBottomRight();
            Screen.CaptureScreen();
            //Console.Beep();

            // LURE
            Util.Sleep(1000);
            CaptureLureSkill();
            //Console.Beep();

            // SKILL
            Util.Sleep(1000);
            CaptureFishSkill();
            //Console.Beep();

            // COLOR => TODO
            Util.Sleep(1000);
            CaptureBobberColor();
            //Console.Beep();

            Logger.Log("All captures complete");
        }

        public static void CaptureTopLeft(int captureDelay = 0)
        {
            Program.mainForm.Inp_TopLeft.Text = "Capturing...";
            Util.Sleep(captureDelay);
            topLeftCords = Mouse.CurrentLocation();
            Program.mainForm.Inp_TopLeft.Text = topLeftCords.ToString();
            Logger.Log($"Top left captured: {topLeftCords}");
        }
        public static void CaptureBottomRight(int captureDelay = 0)
        {
            Program.mainForm.Inp_BottomRight.Text = "Capturing...";
            Util.Sleep(captureDelay);
            bottomRightCords = Mouse.CurrentLocation();
            Program.mainForm.Inp_BottomRight.Text = bottomRightCords.ToString();
            Logger.Log($"Bottom right captured: {bottomRightCords}");
        }
        public static void CaptureLureSkill(int captureDelay = 0)
        {
            Program.mainForm.Inp_LureSkill.Text = "Capturing...";
            Util.Sleep(captureDelay);
            lureSkillCords = Mouse.CurrentLocation();
            Program.mainForm.Inp_LureSkill.Text = lureSkillCords.ToString();
            Logger.Log($"Lure skill captured: {lureSkillCords}");
        }
        public static void CaptureFishSkill(int captureDelay = 0)
        {
            Program.mainForm.Inp_FishSkill.Text = "Capturing...";
            Util.Sleep(captureDelay);
            fishSkillCords = Mouse.CurrentLocation();
            Program.mainForm.Inp_FishSkill.Text = fishSkillCords.ToString();
            Logger.Log($"Fish skill captured: {fishSkillCords}");
        }
        public static void CaptureBobberColor(int captureDelay = 0)
        {
            Program.mainForm.Inp_BobberColor.Text = "Capturing...";
            Util.Sleep(captureDelay);
            bobberColor = Screen.GetColorAtLocation();
            Program.mainForm.Inp_BobberColor.Text = $"{bobberColor.R}, {bobberColor.G}, {bobberColor.B}";
            Logger.Log($"Bobber color captured: {bobberColor}");
        }

        public static void ClearAllCaptureInputs()
        {
            Program.mainForm.UpdatePeakVolueControls(0);
            Program.mainForm.Inp_TopLeft.Text = string.Empty;
            Program.mainForm.Inp_BottomRight.Text = string.Empty;
            Program.mainForm.Inp_LureSkill.Text = string.Empty;
            Program.mainForm.Inp_FishSkill.Text = string.Empty;
            Program.mainForm.Inp_BobberColor.Text = string.Empty;
            Logger.Log("Cleared all capture inputs");
        }

        public static void ValidateConfig()
        {

        }

        public static void SaveConfig()
        {
            Logger.Log("Saving config");
            using (XmlWriter writer = XmlWriter.Create("config.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Config");

                writer.WriteStartElement("TopLeft");
                writer.WriteAttributeString("X", topLeftCords.X.ToString());
                writer.WriteAttributeString("Y", topLeftCords.Y.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("BottomRight");
                writer.WriteAttributeString("X", bottomRightCords.X.ToString());
                writer.WriteAttributeString("Y", bottomRightCords.Y.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("LureSkill");
                writer.WriteAttributeString("X", lureSkillCords.X.ToString());
                writer.WriteAttributeString("Y", lureSkillCords.Y.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("FishSkill");
                writer.WriteAttributeString("X", topLeftCords.X.ToString());
                writer.WriteAttributeString("Y", topLeftCords.Y.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("BobberColor");
                writer.WriteAttributeString("R", bobberColor.R.ToString());
                writer.WriteAttributeString("G", bobberColor.G.ToString());
                writer.WriteAttributeString("B", bobberColor.B.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("TriggerVolume");
                writer.WriteAttributeString("Percent", triggerVolumePercent.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("SleepChance");
                writer.WriteAttributeString("Percent", sleepChancePercent.ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static void ImportConfig()
        {
            Logger.Log("Importing config");
            using (XmlReader reader = XmlReader.Create("config.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "TopLeft":
                                topLeftCords = new Point(int.Parse(reader["X"]), int.Parse(reader["Y"]));
                                break;
                            case "BottomRight":
                                bottomRightCords = new Point(int.Parse(reader["X"]), int.Parse(reader["Y"]));
                                break;
                            case "LureSkill":
                                lureSkillCords = new Point(int.Parse(reader["X"]), int.Parse(reader["Y"]));
                                break;
                            case "FishSkill":
                                fishSkillCords = new Point(int.Parse(reader["X"]), int.Parse(reader["Y"]));
                                break;
                            case "BobberColor":
                                bobberColor = Color.FromArgb(int.Parse(reader["R"]), int.Parse(reader["G"]), int.Parse(reader["B"]));
                                break;
                            case "TriggerVolume":
                                triggerVolumePercent = float.Parse(reader["Percent"]);
                                break;
                            case "SleepChance":
                                sleepChancePercent = float.Parse(reader["Percent"]);
                                break;
                        }
                    }
                }
            }
            Program.mainForm.UpdateAllValues();
        }
    }
}
