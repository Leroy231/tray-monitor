namespace MicIcon
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.batteryFontDialog = new System.Windows.Forms.FontDialog();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.micInterval = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.micBorderText = new System.Windows.Forms.TextBox();
            this.micBorderButton = new System.Windows.Forms.Button();
            this.micBorderOpacity = new System.Windows.Forms.TrackBar();
            this.label29 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.micBackgroundText = new System.Windows.Forms.TextBox();
            this.micBackgroundButton = new System.Windows.Forms.Button();
            this.micBackgroundOpacity = new System.Windows.Forms.TrackBar();
            this.label33 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label36 = new System.Windows.Forms.Label();
            this.micForegroundText = new System.Windows.Forms.TextBox();
            this.micForegroundButton = new System.Windows.Forms.Button();
            this.micForegroundOpacity = new System.Windows.Forms.TrackBar();
            this.label34 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.micBoostEdit = new System.Windows.Forms.NumericUpDown();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micInterval)).BeginInit();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micBorderOpacity)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micBackgroundOpacity)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micForegroundOpacity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micBoostEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // batteryFontDialog
            // 
            this.batteryFontDialog.AllowScriptChange = false;
            this.batteryFontDialog.ShowEffects = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(518, 258);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(156, 44);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(354, 258);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(156, 44);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label31);
            this.panel20.Controls.Add(this.micInterval);
            this.panel20.Controls.Add(this.label28);
            this.panel20.Location = new System.Drawing.Point(-3, 152);
            this.panel20.Margin = new System.Windows.Forms.Padding(4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(675, 48);
            this.panel20.TabIndex = 103;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(8, 12);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(132, 25);
            this.label31.TabIndex = 82;
            this.label31.Text = "Update interval";
            // 
            // micInterval
            // 
            this.micInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.micInterval.Location = new System.Drawing.Point(147, 6);
            this.micInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.micInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.micInterval.Name = "micInterval";
            this.micInterval.Size = new System.Drawing.Size(98, 31);
            this.micInterval.TabIndex = 81;
            this.micInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(248, 12);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(36, 25);
            this.label28.TabIndex = 89;
            this.label28.Text = "ms";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label30);
            this.panel19.Controls.Add(this.micBorderText);
            this.panel19.Controls.Add(this.micBorderButton);
            this.panel19.Controls.Add(this.micBorderOpacity);
            this.panel19.Controls.Add(this.label29);
            this.panel19.Location = new System.Drawing.Point(-3, 104);
            this.panel19.Margin = new System.Windows.Forms.Padding(4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(675, 48);
            this.panel19.TabIndex = 102;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(8, 12);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 25);
            this.label30.TabIndex = 84;
            this.label30.Text = "Border";
            // 
            // micBorderText
            // 
            this.micBorderText.Location = new System.Drawing.Point(147, 6);
            this.micBorderText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micBorderText.Name = "micBorderText";
            this.micBorderText.Size = new System.Drawing.Size(139, 31);
            this.micBorderText.TabIndex = 83;
            // 
            // micBorderButton
            // 
            this.micBorderButton.Location = new System.Drawing.Point(302, 4);
            this.micBorderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micBorderButton.Name = "micBorderButton";
            this.micBorderButton.Size = new System.Drawing.Size(74, 38);
            this.micBorderButton.TabIndex = 85;
            this.micBorderButton.Text = "Color";
            this.micBorderButton.UseVisualStyleBackColor = true;
            this.micBorderButton.Click += new System.EventHandler(this.micBorderButton_Click);
            // 
            // micBorderOpacity
            // 
            this.micBorderOpacity.AutoSize = false;
            this.micBorderOpacity.Location = new System.Drawing.Point(472, 9);
            this.micBorderOpacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micBorderOpacity.Maximum = 255;
            this.micBorderOpacity.Name = "micBorderOpacity";
            this.micBorderOpacity.Size = new System.Drawing.Size(198, 27);
            this.micBorderOpacity.TabIndex = 86;
            this.micBorderOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.micBorderOpacity.Scroll += new System.EventHandler(this.micBorderOpacity_Scroll);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(396, 12);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 25);
            this.label29.TabIndex = 87;
            this.label29.Text = "Opacity";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.label35);
            this.panel18.Controls.Add(this.micBackgroundText);
            this.panel18.Controls.Add(this.micBackgroundButton);
            this.panel18.Controls.Add(this.micBackgroundOpacity);
            this.panel18.Controls.Add(this.label33);
            this.panel18.Location = new System.Drawing.Point(-3, 56);
            this.panel18.Margin = new System.Windows.Forms.Padding(4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(675, 48);
            this.panel18.TabIndex = 101;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(8, 12);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(107, 25);
            this.label35.TabIndex = 74;
            this.label35.Text = "Background";
            // 
            // micBackgroundText
            // 
            this.micBackgroundText.Location = new System.Drawing.Point(147, 6);
            this.micBackgroundText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micBackgroundText.Name = "micBackgroundText";
            this.micBackgroundText.Size = new System.Drawing.Size(139, 31);
            this.micBackgroundText.TabIndex = 73;
            // 
            // micBackgroundButton
            // 
            this.micBackgroundButton.Location = new System.Drawing.Point(302, 4);
            this.micBackgroundButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micBackgroundButton.Name = "micBackgroundButton";
            this.micBackgroundButton.Size = new System.Drawing.Size(74, 38);
            this.micBackgroundButton.TabIndex = 76;
            this.micBackgroundButton.Text = "Color";
            this.micBackgroundButton.UseVisualStyleBackColor = true;
            this.micBackgroundButton.Click += new System.EventHandler(this.micBackgroundButton_Click);
            // 
            // micBackgroundOpacity
            // 
            this.micBackgroundOpacity.AutoSize = false;
            this.micBackgroundOpacity.Location = new System.Drawing.Point(472, 9);
            this.micBackgroundOpacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micBackgroundOpacity.Maximum = 255;
            this.micBackgroundOpacity.Name = "micBackgroundOpacity";
            this.micBackgroundOpacity.Size = new System.Drawing.Size(198, 27);
            this.micBackgroundOpacity.TabIndex = 78;
            this.micBackgroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.micBackgroundOpacity.Scroll += new System.EventHandler(this.micBackgroundOpacity_Scroll);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(396, 12);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(73, 25);
            this.label33.TabIndex = 80;
            this.label33.Text = "Opacity";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label36);
            this.panel17.Controls.Add(this.micForegroundText);
            this.panel17.Controls.Add(this.micForegroundButton);
            this.panel17.Controls.Add(this.micForegroundOpacity);
            this.panel17.Controls.Add(this.label34);
            this.panel17.Location = new System.Drawing.Point(-3, 8);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(675, 48);
            this.panel17.TabIndex = 100;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(8, 12);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(106, 25);
            this.label36.TabIndex = 72;
            this.label36.Text = "Foreground";
            // 
            // micForegroundText
            // 
            this.micForegroundText.Location = new System.Drawing.Point(147, 6);
            this.micForegroundText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micForegroundText.Name = "micForegroundText";
            this.micForegroundText.Size = new System.Drawing.Size(139, 31);
            this.micForegroundText.TabIndex = 71;
            // 
            // micForegroundButton
            // 
            this.micForegroundButton.Location = new System.Drawing.Point(302, 4);
            this.micForegroundButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micForegroundButton.Name = "micForegroundButton";
            this.micForegroundButton.Size = new System.Drawing.Size(74, 38);
            this.micForegroundButton.TabIndex = 75;
            this.micForegroundButton.Text = "Color";
            this.micForegroundButton.UseVisualStyleBackColor = true;
            this.micForegroundButton.Click += new System.EventHandler(this.micForegroundButton_Click);
            // 
            // micForegroundOpacity
            // 
            this.micForegroundOpacity.AutoSize = false;
            this.micForegroundOpacity.Location = new System.Drawing.Point(472, 9);
            this.micForegroundOpacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micForegroundOpacity.Maximum = 255;
            this.micForegroundOpacity.Name = "micForegroundOpacity";
            this.micForegroundOpacity.Size = new System.Drawing.Size(198, 27);
            this.micForegroundOpacity.TabIndex = 77;
            this.micForegroundOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.micForegroundOpacity.Scroll += new System.EventHandler(this.micForegroundOpacity_Scroll);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(396, 12);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(73, 25);
            this.label34.TabIndex = 79;
            this.label34.Text = "Opacity";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.micBoostEdit);
            this.panel1.Location = new System.Drawing.Point(2, 201);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 48);
            this.panel1.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Boost";
            // 
            // micBoostEdit
            // 
            this.micBoostEdit.Location = new System.Drawing.Point(144, 6);
            this.micBoostEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micBoostEdit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.micBoostEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.micBoostEdit.Name = "micBoostEdit";
            this.micBoostEdit.Size = new System.Drawing.Size(142, 31);
            this.micBoostEdit.TabIndex = 38;
            this.micBoostEdit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(678, 308);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "MicIcon Settings";
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micInterval)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micBorderOpacity)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micBackgroundOpacity)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micForegroundOpacity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micBoostEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog batteryFontDialog;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown micInterval;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox micBorderText;
        private System.Windows.Forms.Button micBorderButton;
        private System.Windows.Forms.TrackBar micBorderOpacity;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox micBackgroundText;
        private System.Windows.Forms.Button micBackgroundButton;
        private System.Windows.Forms.TrackBar micBackgroundOpacity;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox micForegroundText;
        private System.Windows.Forms.Button micForegroundButton;
        private System.Windows.Forms.TrackBar micForegroundOpacity;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown micBoostEdit;
    }
}