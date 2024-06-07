using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Diagnostics;
using TrayIconLibrary;
using static TrayIconLibrary.WinApi;

namespace RamIcon
{
    class CustomTrayIcon: TrayIcon
    {
        private CustomSettings settings;
        List<float> measurents = new List<float>();

        public CustomTrayIcon()
        {
            settings = CustomSettings.Instance;

            SetUpdateInterval(settings.updateInterval);
            EnableIcon();
        }

        public override void ContextMenuSettings(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            // immediatly see changes
            SetUpdateInterval(settings.updateInterval);
            UpdateIconTick();
        }

        private bool GetRamLoad(out float load, out float available, out float total)
        {
            MEMORYSTATUSEX memoryStatus = new MEMORYSTATUSEX();
            memoryStatus.dwLength = (int)Marshal.SizeOf(typeof(MEMORYSTATUSEX));

            if (GlobalMemoryStatusEx(ref memoryStatus))
            {
                load = memoryStatus.dwMemoryLoad;
                available = memoryStatus.ullAvailPhys;
                total = memoryStatus.ullTotalPhys;
                return true;
            }
            load = available = total = 0;
            return false;
        }

        public override void UpdateIconTick(object sender = null, EventArgs e = null)
        {
            Color foregroundColor = settings.foregroundColor;
            Color backgroundColor = settings.backgroundColor;
            Color borderColor = settings.borderColor;

            float memLoad, memAvailable, memTotal;
            GetRamLoad(out memLoad, out memAvailable, out memTotal);

            float gbUsed = (memTotal - memAvailable) / 1073741824;
            using (Bitmap bitmap = new Bitmap(DrawText(gbUsed.ToString("F0"), new Font("Microsoft Sans Serif", 14, FontStyle.Bold), foregroundColor, backgroundColor, borderColor)))
            {
                string tooltip = String.Format("RAM:\n{1:F1} / {2:F1} GB ({0:F0}%)", memLoad, (memTotal - memAvailable) / 1073741824, memTotal / 1073741824);
                ChangeIcon(bitmap, tooltip);
            }
        }

        private Image DrawText(String text, Font font, Color textColor, Color backColor, Color borderColor)
        {
            var textSize = GetImageSize(text, font);
            int iconSize = GetTrayIconsSize();
            Image image = new Bitmap(iconSize, iconSize);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                // paint the background
                graphics.Clear(backColor);

                // create a brush for the text
                using (Brush textBrush = new SolidBrush(textColor))
                {
                    int borderWidth = 1;
                    graphics.DrawRectangle(new Pen(borderColor, borderWidth), 0, 0, (int)image.Width - borderWidth, (int)image.Height - borderWidth);

                    graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                    float xScale = 1;
                    float yScale = 1;
                    int allowedCrop = 1;
                    if (text.Length == 1)
                    {
                        // with defaut size digit shifted to the left
                        textSize.Width = (float)(textSize.Width * 0.7);
                        // draw single digit with same width as 2 digits
                        var textSizeForScale = GetImageSize("99", font);
                        xScale = (iconSize + 2 * allowedCrop) / textSizeForScale.Width;
                        yScale = (iconSize + 2 * allowedCrop) / textSizeForScale.Height;
                    }
                    else
                    {
                        xScale = (iconSize + 2 * allowedCrop) / textSize.Width;
                        yScale = (iconSize + 2 * allowedCrop) / textSize.Height;
                    }
                    graphics.ScaleTransform(xScale, yScale);
                    float xPos = (image.Width + 2 * allowedCrop - textSize.Width * xScale) / 2 - allowedCrop;
                    float yPos = (image.Height + 2 * allowedCrop - textSize.Height * yScale) / 2;
                    // move "100" to left, because '1' thinner than '0'
                    if (text.Length == 3)
                    {
                        xPos -= iconSize / 14;
                    }
                    graphics.DrawString(text, font, textBrush, xPos, yPos);
                    graphics.Save();
                }
            }
            return image;
        }

        private static SizeF GetImageSize(string text, Font font)
        {
            using (Image image = new Bitmap(1, 1))
            using (Graphics graphics = Graphics.FromImage(image))
                return graphics.MeasureString(text, font);
        }

        public override void IconHovered()
        {
            float memLoad, memAvailable, memTotal;
            GetRamLoad(out memLoad, out memAvailable, out memTotal);

            string tooltip = String.Format("RAM:\n{1:F1} / {2:F1} GB ({0:F0}%)", memLoad, (memTotal - memAvailable) / 1073741824, memTotal / 1073741824);
            SetTooltip(tooltip);
            SetBalloon(TopMemoryConsumpsionProcesses(), "RamIcon");
        }

        private string TopMemoryConsumpsionProcesses()
        {
            Process[] processes = Process.GetProcesses();
            Array.Sort<Process>(processes, (x, y) => x.WorkingSet64.CompareTo(y.WorkingSet64));
            Array.Reverse(processes);
            string output = "";
            foreach (Process process in processes.Take(5))
            {
                if ((process.SessionId == 0) && (process.HandleCount == 0))
                {
                    // skipping system's "Memory Compression", "Registry" and "Idle" processes
                    System.Console.WriteLine("skipped " + process.ProcessName);
                    continue;
                }
                string processLine = String.Format("{0} ({1})", process.ProcessName, process.Id);
                output += String.Format("{0,-25}\t{1:N0} MB\n", processLine, process.WorkingSet64 / 1048576);
            }
            return output;
        }
    }
}
