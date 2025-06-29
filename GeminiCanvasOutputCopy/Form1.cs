using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using GeminiCanvasOutputCopy.Properties;
using Microsoft.VisualBasic;

namespace GeminiCanvasOutputCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Settings.Default.Reload();
            if (!string.IsNullOrEmpty(Settings.Default.ReplaceValues))
            {
                tbReplace.Text = Settings.Default.ReplaceValues;
            }

            tbPath.Text = Application.StartupPath;
            CodeFiles = new Dictionary<string, string>();
        }

        private Dictionary<string,string> CodeFiles { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            SaveSettings();
        }

        private void btnVerwerk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPath.Text))
            {
                MessageBox.Show("Please select a folder to process.");
                return;
            }

            if (!Directory.Exists(tbPath.Text))
            {
                MessageBox.Show("The specified folder does not exist.");
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbCode.Text))
            {
                MessageBox.Show("Please enter the code to process.");
                return;
            }

            lbStatus.Text = "Processing...";
            ReadCode();
            CheckCodeFile();
            VerwerkCode();

            lbStatus.Text = "Done...";
        }

        private void SaveSettings()
        {

            Settings.Default.ReplaceValues = tbReplace.Text;
            Settings.Default.Save();
        }

        private bool ReadCode()
        {
            SaveSettings();

            // clear previous results
            CodeFiles.Clear();

            //Read code from the RichTextBox
            var gcode = rtbCode.Text.Trim();
            if (string.IsNullOrEmpty(gcode))
            {
                MessageBox.Show("No code to process.");
                return false;
            }

            // Replace values if specified
            if (!string.IsNullOrEmpty(tbReplace.Text))
            {
                var replaceValues = tbReplace.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var replaceValue in replaceValues)
                {
                    var parts = replaceValue.Split(new[] { ';' }, 2);
                    if (parts.Length == 2)
                    {
                        gcode = gcode.Replace(parts[0].Trim(), parts[1].Trim());
                    }
                }
            }

            StringBuilder code = new StringBuilder();
            string fileFound = string.Empty;

            // Split the code into lines
            var lines = gcode.Split(new[] { '\n' });
            foreach (var line in lines)
            {
                if (line.StartsWith("// ===== FILENAME:"))
                {
                    // New file found, save the previous one if it exists
                    if (!string.IsNullOrEmpty(fileFound))
                    {
                        CodeFiles[fileFound] = code.ToString();
                        code.Clear();
                    }
                    fileFound = line.Substring(20,line.Length - 20 - 6).Trim();
                    
                }
                else
                {
                    if (!string.IsNullOrEmpty(fileFound))
                    {
                        code.AppendLine(line);
                    }
                }
            }

            if (!string.IsNullOrEmpty(fileFound))
            {
                CodeFiles[fileFound] = code.ToString();
                code.Clear();
            }
            
            return true;
        }

        private void CheckCodeFile()
        {
            foreach (var file in CodeFiles)
            {
                if (file.Key.EndsWith("xml", StringComparison.OrdinalIgnoreCase) && file.Value.StartsWith("/*"))
                {
                    CodeFiles[file.Key] = file.Value.TrimStart("/*".ToCharArray()).TrimEnd("*/".ToCharArray()).Trim();
                }
            }
        }

        private void VerwerkCode()
        {
            foreach (var file in CodeFiles)
            {
                var filePath = Path.Combine(tbPath.Text, file.Key.Replace("/", "\\"));
                try
                {
                    // Ensure the directory exists
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath) ?? string.Empty);
                    // Write the code to the file
                    File.WriteAllText(filePath, file.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing file {file.Key}: {ex.Message}");
                }
            }
        }
    }
}
