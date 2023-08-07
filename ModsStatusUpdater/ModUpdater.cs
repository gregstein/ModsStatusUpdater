using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace ModsStatusUpdater
{
    class ModUpdater
    {
        private readonly string _baseFolderPath;
        
        public ModUpdater(string baseFolderPath)
        {
            _baseFolderPath = Environment.ExpandEnvironmentVariables(baseFolderPath);
        }

        public void UpdateModStatus(bool valmod = false)
        {
           

            bool _passed = false;
            string[] subdirectories = Directory.GetDirectories(_baseFolderPath, "*", SearchOption.TopDirectoryOnly);

            foreach (string subdirectory in subdirectories)
            {
                string folderName = Path.GetFileName(subdirectory);
                if (folderName.Length > 5 && folderName.Trim().All(char.IsDigit))
                {
                    string modStatusFilePath = Path.Combine(subdirectory, "mods", "mod-status.json");
                    

                    if (File.Exists(modStatusFilePath))
                    {
                        try
                        {
                            UpdateJsonFile(modStatusFilePath, valmod);
                            _passed = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error processing mod status file in folder {subdirectory}: {ex.Message}");
                        }
                    }
                }
            }
            if(_passed)
            {
                if (valmod == false)
                    MessageBox.Show("All Disabled Successfully!", "All Mods Disabled!");
                else
                    MessageBox.Show("All Enabled Successfully!", "All Mods Enabled!");
            }
            
        }

        private void UpdateJsonFile(string filePath, bool valmod = false)
        {
            

            try
            {


             

                string jsonContent = File.ReadAllText(filePath);

                int modsIndex = jsonContent.IndexOf("\"Mods\": [");
                if (modsIndex >= 0)
                {
                    int modsEndIndex = jsonContent.IndexOf("]", modsIndex);
                    if (modsEndIndex > modsIndex)
                    {
                        string modsArray = jsonContent.Substring(modsIndex, modsEndIndex - modsIndex + 1);

                        // Replace with a space after the colon
                        modsArray = modsArray.Replace("\"Enabled\": true", "\"Enabled\": " + (valmod ? "true" : "false"));
                        modsArray = modsArray.Replace("\"Enabled\": false", "\"Enabled\": " + (valmod ? "true" : "false"));

                        // Replace without spaces around the colon
                        modsArray = modsArray.Replace("\"Enabled\":true", "\"Enabled\": " + (valmod ? "true" : "false"));
                        modsArray = modsArray.Replace("\"Enabled\":false", "\"Enabled\": " + (valmod ? "true" : "false"));

                        jsonContent = jsonContent.Substring(0, modsIndex) + modsArray + jsonContent.Substring(modsEndIndex + 1);
                    }
                }
                
                File.WriteAllText(filePath, jsonContent);

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("File permission issue detected. Please restart the application as an administrator.");
                DialogResult restartDialogResult = MessageBox.Show("Do you want to restart the application now?", "Restart Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (restartDialogResult == DialogResult.Yes)
                {
                    // Restart the application with administrative privileges
                    var processInfo = new ProcessStartInfo
                    {
                        FileName = Application.ExecutablePath,
                        UseShellExecute = true,
                        Verb = "runas" // Run as administrator
                    };

                    try
                    {
                        Process.Start(processInfo);
                        Application.Exit(); // Close the current instance
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to restart as administrator: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exd)
            {
                MessageBox.Show($"Error processing mod status file: {exd.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
    }
}
