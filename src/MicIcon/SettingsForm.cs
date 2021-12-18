using TrayIconLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;

namespace MicIcon
{
    public partial class SettingsForm : Form
    {
        CustomSettings settings;

        public SettingsForm()
        {
            InitializeComponent();

            // load settings
            settings = CustomSettings.Instance;
            micForegroundText.Text = Utils.ColorToString(settings.foregroundColor);
            micForegroundOpacity.Value = settings.foregroundColor.A;
            micBackgroundText.Text = Utils.ColorToString(settings.backgroundColor);
            micBackgroundOpacity.Value = settings.backgroundColor.A;
            micBorderText.Text = Utils.ColorToString(settings.borderColor);
            micBorderOpacity.Value = settings.borderColor.A;
            micInterval.Value = settings.updateInterval;
            micBoostEdit.Value = settings.boost;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            settings.foregroundColor = Utils.ColorFromString(micForegroundText.Text);
            settings.backgroundColor = Utils.ColorFromString(micBackgroundText.Text);
            settings.borderColor = Utils.ColorFromString(micBorderText.Text);
            settings.updateInterval = (int)micInterval.Value;
            settings.boost = (int)micBoostEdit.Value;

            Close();
        }

        private void micForegroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(micForegroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(micForegroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            micForegroundText.Text = Utils.ColorToString(color);
        }

        private void micBackgroundButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(micBackgroundText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(micBackgroundOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            micBackgroundText.Text = Utils.ColorToString(color);
        }

        private void micBorderButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Utils.ColorFromString(micBorderText.Text);
            colorDialog.ShowDialog();
            Color color = Color.FromArgb(micBorderOpacity.Value, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            micBorderText.Text = Utils.ColorToString(color);
        }

        private void micForegroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(micForegroundText.Text);
            Color color2 = Color.FromArgb(micForegroundOpacity.Value, color.R, color.G, color.B);
            micForegroundText.Text = Utils.ColorToString(color2);
        }

        private void micBackgroundOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(micBackgroundText.Text);
            Color color2 = Color.FromArgb(micBackgroundOpacity.Value, color.R, color.G, color.B);
            micBackgroundText.Text = Utils.ColorToString(color2);
        }

        private void micBorderOpacity_Scroll(object sender, EventArgs e)
        {
            Color color = Utils.ColorFromString(micBorderText.Text);
            Color color2 = Color.FromArgb(micBorderOpacity.Value, color.R, color.G, color.B);
            micBorderText.Text = Utils.ColorToString(color2);
        }
    }
}
