using System.Diagnostics;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace MediaDownloader
{

    public partial class Form1 : Form
    {
        private string ytDlpPath;
        private string ffmpegPath;

        public Form1()
        {
            InitializeComponent();

            ytDlpPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "yt-dlp.exe");
            ffmpegPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ffmpeg.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAudioFormat.Enabled = false;
            cmbVideoFormat.Enabled = false;
        }


        private async void btnDownload_Click(object sender, EventArgs e)
        {
            //A checkbox must be checked
            if (!rbVideo.Checked && !rbAudio.Checked)
            {
                DisplayOutput("Error: At least one type must be checked.");
                return;
            }

            if (txtPath.Text=="")
            {
                DisplayOutput("Error: A download path must be selected.");
                return;
            }

            string videoUrl = txtURL.Text.Trim();
            if (string.IsNullOrEmpty(videoUrl))
            {
                MessageBox.Show("Please enter a YouTube video URL.");
                return;
            }

            // Handling of custom output file names
            string customName = txtCustomName.Text.Trim();
            //string outputDirectory = "Downloads";
            Directory.CreateDirectory("Downloads");
            string outputFileName;
            if (string.IsNullOrEmpty(customName))
            {
                outputFileName = "";
            }
            else
            {
                outputFileName = $"--output \"{customName}\" ";
            }

            // Construct the download command based on selected formats
            StringBuilder downloadCommand = new StringBuilder();

            // Append ffmpeg's location
            downloadCommand.Append($"--ffmpeg-location \"{ffmpegPath}\" ");

            //Append the Download Path
            downloadCommand.Append(outputFileName);

            if (rbAudio.Checked)
            {
                downloadCommand.Append($"-x --audio-format {cmbAudioFormat.SelectedItem?.ToString()} ");
            }

            if (chkFormatSelect.Checked)
            {
                downloadCommand.Append($"-f {txtVideoformat.Text}+{txtAudioformat.Text} ");
            }

            if (chkThumbnail.Checked)
            {
                downloadCommand.Append($"--embed-thumbnail ");
            }

            if (chkMetadata.Checked)
            {
                downloadCommand.Append($"--add-metadata ");
            }

            // Append the URL
            downloadCommand.Append($"\"{txtURL.Text}\"");

            // Display the command before executing
            DisplayOutput("");
            DisplayOutput($"Download Command: {downloadCommand.ToString()}");

            // Get WorkingDirectory
            /*string workingDir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Downloads");*/
            string workingDir = $"{txtPath.Text}";
            var filename = "";

            using (Process process = new Process())
            {
                process.StartInfo.FileName = ytDlpPath;
                process.StartInfo.WorkingDirectory = workingDir;
                process.StartInfo.Arguments = $"{downloadCommand}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                // Event handler for real-time output
                process.OutputDataReceived += (s, ev) =>
                {
                    var msg = ev.Data;
                    if (msg == null) return; // we love return early

                    if (msg.StartsWith("[Merger] Merging formats into "))
                    {
                        // '[Merger] Merging formats into "'.length=31
                        filename = msg.Substring(31, msg.Length - 1 - 31);
                    }
                    if (msg.EndsWith("has already been downloaded"))
                    {
                        // '[download] '.length=11
                        // 'has already been downloaded'.length=27
                        filename = msg.Substring(11, msg.Length - 27 - 11 - 1);
                    }

                    DisplayOutput(msg);
                };
                process.ErrorDataReceived += (s, ev) => DisplayOutput(ev.Data);

                pictureBox1.Image = Properties.Resources.maddyspin;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // Start the process
                process.Start();

                // Begin asynchronous reading of the output and error streams
                Task outputTask = Task.Run(() => process.BeginOutputReadLine());
                Task errorTask = Task.Run(() => process.BeginErrorReadLine());

                // Wait for the process to exit
                await process.WaitForExitAsync();

                // Display the final exit code
                DisplayOutput($"Download finished with exit code: {process.ExitCode}");

                process.Close();
            }
            pictureBox1.Image = Properties.Resources.widegladeline;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (rbVideo.Checked && filename != "" && !chkSkipEncoding.Checked)
            {
                reencode(Path.Join(workingDir, filename), cmbVideoFormat.SelectedItem?.ToString());
            }
        }

        private async void reencode(string filename, string encoding)
        {
            using (Process process = new Process())
            {
                var newFile = Path.ChangeExtension(filename, encoding);
                if (newFile == filename)
                {
                    // we can just return out, since the file ext isn't changed
                    return;
                }
                process.StartInfo.FileName = ffmpegPath;
                process.StartInfo.Arguments = $"-i \"{filename}\" \"{newFile}\" -y";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                // Event handler for real-time output
                process.OutputDataReceived += (s, ev) => DisplayOutput(ev.Data);
                process.ErrorDataReceived += (s, ev) => DisplayOutput(ev.Data);

                pictureBox1.Image = Properties.Resources.maddyspin;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Start the process
                process.Start();

                // Begin asynchronous reading of the output and error streams
                Task outputTask = Task.Run(() => process.BeginOutputReadLine());
                Task errorTask = Task.Run(() => process.BeginErrorReadLine());

                // Wait for the process to exit
                await process.WaitForExitAsync();

                // Display the final exit code
                DisplayOutput($"Re-encoding finished with exit code: {process.ExitCode}");

                process.Close();
            }
            pictureBox1.Image = Properties.Resources.widegladeline;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void DisplayOutput(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                // Update the RichTextBox with real-time output
                BeginInvoke((Action)(() =>
                {
                    rtbOutput.AppendText(message + Environment.NewLine);

                    // Scroll to the end
                    rtbOutput.SelectionStart = rtbOutput.Text.Length;
                    rtbOutput.ScrollToCaret();
                }));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbVideo_CheckedChanged(object sender, EventArgs e)
        {
            // Enable or disable the video format ComboBox based on the checked state
            cmbVideoFormat.Enabled = rbVideo.Checked;

            // If video is checked, uncheck audio
            if (rbVideo.Checked)
            {
                rbAudio.Checked = false;
            }
        }

        private void rbAudio_CheckedChanged(object sender, EventArgs e)
        {
            // Enable or disable the audio format ComboBox based on the checked state
            cmbAudioFormat.Enabled = rbAudio.Checked;

            // If audio is checked, uncheck video
            if (rbAudio.Checked)
            {
                rbVideo.Checked = false;
            }
        }

        private async void btnFormatcheck_Click(object sender, EventArgs e)
        {

            string formatCheckCommand = $"--list-formats {txtURL.Text}";

            // Display the command before executing
            DisplayOutput("");
            DisplayOutput($"Format check: \"{formatCheckCommand.ToString()}\"");

            using (Process process = new Process())
            {
                process.StartInfo.FileName = ytDlpPath;
                process.StartInfo.Arguments = $"{formatCheckCommand}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                // Event handler for real-time output
                process.OutputDataReceived += (s, ev) => DisplayOutput(ev.Data);
                process.ErrorDataReceived += (s, ev) => DisplayOutput(ev.Data);

                // Start the process
                process.Start();

                // Begin asynchronous reading of the output and error streams
                Task outputTask = Task.Run(() => process.BeginOutputReadLine());
                Task errorTask = Task.Run(() => process.BeginErrorReadLine());

                // Wait for the process to exit
                await process.WaitForExitAsync();

                // Display the final exit code
                DisplayOutput($"Formatcheck finished with exit code: {process.ExitCode}");

                process.Close();
            }
        }

        private void btnFormatinfobox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecting custom formats via format selection is OPTIONAL!", "Format select", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            DialogResult downloadPath = folderBrowserDialog1.ShowDialog();
            if (downloadPath == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }

            /*using (Process process = new Process())
            {
                process.StartInfo.FileName = "explorer.exe";
                process.StartInfo.Arguments = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Downloads");
                process.Start();
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSkipEncInfo_Click(object sender, EventArgs e)
        {
            string skipencodemsg = "It's recommended to skip encoding when downloading a large file or you don't want the download taking ages! Skipping encoding will skip the conversion to incompatible formats.";
            MessageBox.Show(skipencodemsg, "Format select", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public static class ProcessExtensions
    {
        public static Task WaitForExitAsync(this Process process)
        {
            var tcs = new TaskCompletionSource<bool>();

            process.EnableRaisingEvents = true;
            process.Exited += (sender, args) => tcs.TrySetResult(true);

            return tcs.Task;
        }
    }
}