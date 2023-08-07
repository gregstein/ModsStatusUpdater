using ModLocker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModsStatusUpdater
{
    public partial class Main : Form
    {
        private bool isClosingConfirmed = false;
        private List<FileStream> fileStream = null; // Store the file stream for locking
  
        public Main()
        {
            InitializeComponent();
            lkjson.CheckedChanged += lkjson_CheckedChanged;

        }
        public string _baseFolderPath = Environment.ExpandEnvironmentVariables(@"%userprofile%\Games\Age of Empires 2 DE");
        ModUpdater modUpdater = new ModUpdater(Environment.ExpandEnvironmentVariables(@"%userprofile%\Games\Age of Empires 2 DE"));
        private void isDERUNNING()
        {
            Process[] pname = Process.GetProcessesByName("AoE2DE_s");
            if (pname.Length != 0)
            {
                MessageBox.Show("Please Close AoE2DE Before Using The Tool!", "Close Age of Empires 2 DE");
                Application.Exit();
            }
        }
        static bool IsFileReadable(string filePath)
        {
            try
            {
                using (FileStream fileStream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    return true;
                }
            }
            catch (SystemException)
            {
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            isDERUNNING();
            ModStatusCheck();

        }

        private void dismods_Click(object sender, EventArgs e)
        {
            
            modUpdater.UpdateModStatus();  
        }

        private void enabmods_Click(object sender, EventArgs e)
        {
           
            modUpdater.UpdateModStatus(true);
        }
        private void ModStatusCheck()
        {
            string[] subdirectories = Directory.GetDirectories(_baseFolderPath, "*", SearchOption.TopDirectoryOnly);
            bool _onceren = false;
            foreach (string subdirectory in subdirectories)
            {
                string folderName = Path.GetFileName(subdirectory);
                if (folderName.Length > 5 && folderName.Trim().All(char.IsDigit))
                {
                    string modStatusFilePath = Path.Combine(subdirectory, "mods", "mod-status.json");


                    if (File.Exists(modStatusFilePath))
                    {
                       if(!IsFileReadable(modStatusFilePath))
                        {
                            lkjson.Checked = true;
                            cbdis.Enabled = false;
                            if(!_onceren)
                            {
                                _onceren = true;
                                cbdis.Text += " (Disabled due to Lock)";
                            }
                        }
                       else
                        {

                        }
                    }
                }
            }
        }
        private void ModLocker(bool lockon=false)
        {
            string[] subdirectories = Directory.GetDirectories(_baseFolderPath, "*", SearchOption.TopDirectoryOnly);

            foreach (string subdirectory in subdirectories)
            {
                string folderName = Path.GetFileName(subdirectory);
                if (folderName.Length > 5 && folderName.Trim().All(char.IsDigit))
                {
                    string modStatusFilePath = Path.Combine(subdirectory, "mods", "mod-status.json");


                    if (File.Exists(modStatusFilePath))
                    {
                        if(lockon)
                        {
                            FileProcess.resetPERMISIONS(modStatusFilePath);
                            cbdis.Enabled = true;
                            cbdis.Text = "Disable All Mods";
                        }
                        else
                        {
                            FileProcess.setREADONLY(modStatusFilePath);
                            cbdis.Enabled = false;
                            cbdis.Text = "Disable All Mods (Disabled due to Lock)";
                        }
                    }
                }
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void cbdis_CheckedChanged(object sender, EventArgs e)
        {
            if(cbdis.Checked)
            {
                modUpdater.UpdateModStatus();
            }
            else
            {
                modUpdater.UpdateModStatus(true);

            }
        }
        private void DelSubscribed()
        {
            string[] subdirectories = Directory.GetDirectories(_baseFolderPath, "*", SearchOption.TopDirectoryOnly);

            foreach (string subdirectory in subdirectories)
            {
                string folderName = Path.GetFileName(subdirectory);
                if (folderName.Length > 5 && folderName.Trim().All(char.IsDigit))
                {
                    string subed = Path.Combine(subdirectory, "mods\\subscribed");
                    DialogResult result = MessageBox.Show($"Do you want to delete the folder '{subed}' and its contents?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Delete the subdirectory and its contents
                        Directory.Delete(subed, true);
                        MessageBox.Show($"Folder '{subed}' and its contents deleted.", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Deletion of '{subed}' and its contents canceled.", "Deletion Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
        }
        private void lkjson_CheckedChanged(object sender, EventArgs e)
        {
           
            if(lkjson.Checked == true && lkjson.Focus())
            {
                ModLocker();

            }
            else if (lkjson.Checked == false && lkjson.Focus())
            {
                    ModLocker(true);

            }
        }

        private void delmods_CheckedChanged(object sender, EventArgs e)
        {
            DelSubscribed();
        }
    }
}
