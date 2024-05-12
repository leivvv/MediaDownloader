namespace MediaDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.txtCustomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVideoFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAudioFormat = new System.Windows.Forms.ComboBox();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbAudio = new System.Windows.Forms.RadioButton();
            this.chkFormatSelect = new System.Windows.Forms.CheckBox();
            this.txtVideoformat = new System.Windows.Forms.TextBox();
            this.txtAudioformat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFormatcheck = new System.Windows.Forms.Button();
            this.btnFormatinfobox = new System.Windows.Forms.Button();
            this.chkMetadata = new System.Windows.Forms.CheckBox();
            this.chkThumbnail = new System.Windows.Forms.CheckBox();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkSkipEncoding = new System.Windows.Forms.CheckBox();
            this.btnSkipEncInfo = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(115, 15);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(537, 23);
            this.txtURL.TabIndex = 0;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(658, 15);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(128, 24);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(15, 296);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(773, 560);
            this.rtbOutput.TabIndex = 2;
            this.rtbOutput.Text = "";
            // 
            // txtCustomName
            // 
            this.txtCustomName.Location = new System.Drawing.Point(205, 53);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(447, 23);
            this.txtCustomName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter media URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter custom file name (optional)";
            // 
            // cmbVideoFormat
            // 
            this.cmbVideoFormat.FormattingEnabled = true;
            this.cmbVideoFormat.Items.AddRange(new object[] {
            "webm",
            "mp4",
            "mkv",
            "mov"});
            this.cmbVideoFormat.Location = new System.Drawing.Point(76, 147);
            this.cmbVideoFormat.Name = "cmbVideoFormat";
            this.cmbVideoFormat.Size = new System.Drawing.Size(121, 23);
            this.cmbVideoFormat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Video format";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Audio format";
            // 
            // cmbAudioFormat
            // 
            this.cmbAudioFormat.FormattingEnabled = true;
            this.cmbAudioFormat.Items.AddRange(new object[] {
            "mp3",
            "vorbis",
            "wav",
            "m4a",
            "aac"});
            this.cmbAudioFormat.Location = new System.Drawing.Point(76, 185);
            this.cmbAudioFormat.Name = "cmbAudioFormat";
            this.cmbAudioFormat.Size = new System.Drawing.Size(121, 23);
            this.cmbAudioFormat.TabIndex = 11;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(15, 147);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(55, 19);
            this.rbVideo.TabIndex = 12;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            // 
            // rbAudio
            // 
            this.rbAudio.AutoSize = true;
            this.rbAudio.Location = new System.Drawing.Point(15, 185);
            this.rbAudio.Name = "rbAudio";
            this.rbAudio.Size = new System.Drawing.Size(57, 19);
            this.rbAudio.TabIndex = 13;
            this.rbAudio.TabStop = true;
            this.rbAudio.Text = "Audio";
            this.rbAudio.UseVisualStyleBackColor = true;
            // 
            // chkFormatSelect
            // 
            this.chkFormatSelect.AutoSize = true;
            this.chkFormatSelect.Location = new System.Drawing.Point(399, 149);
            this.chkFormatSelect.Name = "chkFormatSelect";
            this.chkFormatSelect.Size = new System.Drawing.Size(107, 19);
            this.chkFormatSelect.TabIndex = 14;
            this.chkFormatSelect.Text = "Custom format";
            this.chkFormatSelect.UseVisualStyleBackColor = true;
            // 
            // txtVideoformat
            // 
            this.txtVideoformat.Location = new System.Drawing.Point(512, 149);
            this.txtVideoformat.Name = "txtVideoformat";
            this.txtVideoformat.Size = new System.Drawing.Size(100, 23);
            this.txtVideoformat.TabIndex = 15;
            // 
            // txtAudioformat
            // 
            this.txtAudioformat.Location = new System.Drawing.Point(512, 178);
            this.txtAudioformat.Name = "txtAudioformat";
            this.txtAudioformat.Size = new System.Drawing.Size(100, 23);
            this.txtAudioformat.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Video select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Audio select";
            // 
            // btnFormatcheck
            // 
            this.btnFormatcheck.Location = new System.Drawing.Point(399, 179);
            this.btnFormatcheck.Name = "btnFormatcheck";
            this.btnFormatcheck.Size = new System.Drawing.Size(107, 23);
            this.btnFormatcheck.TabIndex = 19;
            this.btnFormatcheck.Text = "Check Formats";
            this.btnFormatcheck.UseVisualStyleBackColor = true;
            // 
            // btnFormatinfobox
            // 
            this.btnFormatinfobox.BackgroundImage = global::MediaDownloader.Properties.Resources.balazsleo;
            this.btnFormatinfobox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormatinfobox.Location = new System.Drawing.Point(374, 148);
            this.btnFormatinfobox.Name = "btnFormatinfobox";
            this.btnFormatinfobox.Size = new System.Drawing.Size(19, 19);
            this.btnFormatinfobox.TabIndex = 20;
            this.btnFormatinfobox.UseVisualStyleBackColor = true;
            // 
            // chkMetadata
            // 
            this.chkMetadata.AutoSize = true;
            this.chkMetadata.Location = new System.Drawing.Point(13, 227);
            this.chkMetadata.Name = "chkMetadata";
            this.chkMetadata.Size = new System.Drawing.Size(101, 19);
            this.chkMetadata.TabIndex = 21;
            this.chkMetadata.Text = "Add metadata";
            this.chkMetadata.UseVisualStyleBackColor = true;
            // 
            // chkThumbnail
            // 
            this.chkThumbnail.AutoSize = true;
            this.chkThumbnail.Location = new System.Drawing.Point(13, 252);
            this.chkThumbnail.Name = "chkThumbnail";
            this.chkThumbnail.Size = new System.Drawing.Size(106, 19);
            this.chkThumbnail.TabIndex = 22;
            this.chkThumbnail.Text = "Add thumbnail";
            this.chkThumbnail.UseVisualStyleBackColor = true;
            // 
            // btnExplorer
            // 
            this.btnExplorer.Location = new System.Drawing.Point(658, 92);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(128, 23);
            this.btnExplorer.TabIndex = 23;
            this.btnExplorer.Text = "Download directory";
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MediaDownloader.Properties.Resources.widegladeline;
            this.pictureBox1.Location = new System.Drawing.Point(711, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // chkSkipEncoding
            // 
            this.chkSkipEncoding.AutoSize = true;
            this.chkSkipEncoding.Location = new System.Drawing.Point(139, 227);
            this.chkSkipEncoding.Name = "chkSkipEncoding";
            this.chkSkipEncoding.Size = new System.Drawing.Size(101, 19);
            this.chkSkipEncoding.TabIndex = 25;
            this.chkSkipEncoding.Text = "Skip encoding";
            this.chkSkipEncoding.UseVisualStyleBackColor = true;
            // 
            // btnSkipEncInfo
            // 
            this.btnSkipEncInfo.BackgroundImage = global::MediaDownloader.Properties.Resources.balazsleo;
            this.btnSkipEncInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkipEncInfo.Location = new System.Drawing.Point(246, 227);
            this.btnSkipEncInfo.Name = "btnSkipEncInfo";
            this.btnSkipEncInfo.Size = new System.Drawing.Size(19, 19);
            this.btnSkipEncInfo.TabIndex = 26;
            this.btnSkipEncInfo.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(109, 92);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(543, 23);
            this.txtPath.TabIndex = 27;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Download Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 868);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSkipEncInfo);
            this.Controls.Add(this.chkSkipEncoding);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExplorer);
            this.Controls.Add(this.chkThumbnail);
            this.Controls.Add(this.chkMetadata);
            this.Controls.Add(this.btnFormatinfobox);
            this.Controls.Add(this.btnFormatcheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAudioformat);
            this.Controls.Add(this.txtVideoformat);
            this.Controls.Add(this.chkFormatSelect);
            this.Controls.Add(this.rbAudio);
            this.Controls.Add(this.rbVideo);
            this.Controls.Add(this.cmbAudioFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbVideoFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomName);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "MediaDownloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtURL;
        private Button btnDownload;
        private RichTextBox rtbOutput;
        private TextBox txtCustomName;
        private Label label1;
        private Label label2;
        private ComboBox cmbVideoFormat;
        private Label label3;
        private Label label4;
        private ComboBox cmbAudioFormat;
        private RadioButton rbVideo;
        private RadioButton rbAudio;
        private CheckBox chkFormatSelect;
        private TextBox txtVideoformat;
        private TextBox txtAudioformat;
        private Label label5;
        private Label label6;
        private Button btnFormatcheck;
        private Button btnFormatinfobox;
        private CheckBox chkMetadata;
        private CheckBox chkThumbnail;
        private Button btnExplorer;
        private PictureBox pictureBox1;
        private CheckBox chkSkipEncoding;
        private Button btnSkipEncInfo;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtPath;
        private Label label7;
    }
}