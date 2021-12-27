using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using TrayIconLibrary;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.Threading;

namespace MicIcon
{
    class CustomTrayIcon: TrayIcon
    {
        private CustomSettings settings;
        List<float> measurementsPercents = new List<float>();
        List<PerformanceCounter> counters = new List<PerformanceCounter>();
        WaveInEvent waveIn = new WaveInEvent();
        float value = 0;
        bool recStarted = false;
        string deviceName = "";

        public CustomTrayIcon()
        {
            settings = CustomSettings.Instance;

            waveIn.DataAvailable += (sender, args) =>
            {
                for (int index = 0; index < args.BytesRecorded; index += 2)
                {
                    short sample = (short)((args.Buffer[index + 1] << 8) | args.Buffer[index + 0]);
                    float sample32 = sample / 32768f;
                    if (sample32 < 0) sample32 = -sample32;
                    if (sample32 > value) value = sample32;
                }
            };
            UpdateDeviceList();
            waveIn.StartRecording();
            recStarted = true;

            // periodical check for changed default device
            var checkDeviceTimer = new System.Windows.Forms.Timer();
            checkDeviceTimer.Interval = 60 * 1000;
            checkDeviceTimer.Tick += (sender, args) => { UpdateDeviceList(); };
            checkDeviceTimer.Start();

            SetUpdateInterval(settings.updateInterval);
            EnableIcon();
        }

        public void UpdateDeviceList()
        {
            var enumerator = new MMDeviceEnumerator();
            var wasapi = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);
            var default_device = wasapi.FriendlyName;
            deviceName = default_device;

            waveIn.DeviceNumber = -1;
            for (int n = -1; n < WaveIn.DeviceCount; n++)
            {
                var caps = WaveIn.GetCapabilities(n);
                if (default_device.Contains(caps.ProductName) && waveIn.DeviceNumber != n)
                {
                    if (recStarted) waveIn.StopRecording();
                    waveIn.DeviceNumber = n;
                    if (recStarted)
                    {
                        Thread.Sleep(100);
                        waveIn.StartRecording();
                    }
                    break;
                }
            }
        }

        public override void ContextMenuSettings(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
            // immediatly see changes
            UpdateDeviceList();
            SetUpdateInterval(settings.updateInterval);
            UpdateIconTick();
        }

        public override void IconMouseDoubleClickAction() {}

        public override void UpdateIconTick(object sender = null, EventArgs e = null)
        {
            Color foregroundColor = settings.foregroundColor;
            Color backgroundColor = settings.backgroundColor;
            Color borderColor = settings.borderColor;

            int pointWidth = WidthSingleMeasurement();

            int iconSize = GetTrayIconsSize();
            using (Bitmap bitmap = new Bitmap(iconSize, iconSize))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(backgroundColor);

                    measurementsPercents.Add(value * 100 * settings.boost / 10);
                    value = 0;

                    if (measurementsPercents.Count > bitmap.Width / pointWidth)
                    {
                        measurementsPercents.RemoveAt(0);
                    }

                    for (int i = measurementsPercents.Count - 1; i >= 0; i--)
                    {
                        float value = measurementsPercents[i];
                        var pos = bitmap.Width - (measurementsPercents.Count - 1 - i) * pointWidth;
                        graphics.DrawLine(new Pen(foregroundColor, pointWidth), pos, bitmap.Height, pos, bitmap.Height - bitmap.Height * value / 100);
                    }

                    int borderWidth = 1;
                    graphics.DrawRectangle(new Pen(borderColor, borderWidth), 0, 0, (int)bitmap.Width - borderWidth, (int)bitmap.Height - borderWidth);

                    graphics.Save();
                    ChangeIcon(bitmap, deviceName);
                }
            }
        }
    }
}
