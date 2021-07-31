namespace Mp3MetaDataManager
{
    partial class Form1
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
            this.tbFilepath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.lbFormatLabel = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.tbFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCurrentInformation = new System.Windows.Forms.GroupBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbFileNr = new System.Windows.Forms.Label();
            this.gbCurrentFile = new System.Windows.Forms.GroupBox();
            this.tbCurrentArtist = new System.Windows.Forms.TextBox();
            this.tbCurrentFileName = new System.Windows.Forms.TextBox();
            this.tbCurrentFileNr = new System.Windows.Forms.TextBox();
            this.tbCurrentAlbum = new System.Windows.Forms.TextBox();
            this.tbCurrentYear = new System.Windows.Forms.TextBox();
            this.tbCurrentGenre = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.gbCurrentInformation.SuspendLayout();
            this.gbCurrentFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilepath
            // 
            this.tbFilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilepath.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbFilepath.Location = new System.Drawing.Point(12, 11);
            this.tbFilepath.Name = "tbFilepath";
            this.tbFilepath.ReadOnly = true;
            this.tbFilepath.Size = new System.Drawing.Size(491, 20);
            this.tbFilepath.TabIndex = 0;
            this.tbFilepath.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(509, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Items.AddRange(new object[] {
            ""});
            this.lbFiles.Location = new System.Drawing.Point(12, 37);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(572, 134);
            this.lbFiles.TabIndex = 0;
            this.lbFiles.TabStop = false;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            // 
            // lbFormatLabel
            // 
            this.lbFormatLabel.AutoSize = true;
            this.lbFormatLabel.Location = new System.Drawing.Point(12, 180);
            this.lbFormatLabel.Name = "lbFormatLabel";
            this.lbFormatLabel.Size = new System.Drawing.Size(42, 13);
            this.lbFormatLabel.TabIndex = 3;
            this.lbFormatLabel.Text = "Format:";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrent.Location = new System.Drawing.Point(56, 177);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(528, 20);
            this.tbCurrent.TabIndex = 0;
            this.tbCurrent.TabStop = false;
            // 
            // tbFormat
            // 
            this.tbFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFormat.Location = new System.Drawing.Point(56, 203);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(528, 20);
            this.tbFormat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current:";
            // 
            // gbCurrentInformation
            // 
            this.gbCurrentInformation.Controls.Add(this.tbGenre);
            this.gbCurrentInformation.Controls.Add(this.tbYear);
            this.gbCurrentInformation.Controls.Add(this.tbAlbum);
            this.gbCurrentInformation.Controls.Add(this.tbArtist);
            this.gbCurrentInformation.Controls.Add(this.tbFileName);
            this.gbCurrentInformation.Controls.Add(this.tbNumber);
            this.gbCurrentInformation.Controls.Add(this.label3);
            this.gbCurrentInformation.Controls.Add(this.lbYear);
            this.gbCurrentInformation.Controls.Add(this.lbAlbum);
            this.gbCurrentInformation.Controls.Add(this.lbArtist);
            this.gbCurrentInformation.Controls.Add(this.lbFileName);
            this.gbCurrentInformation.Controls.Add(this.lbFileNr);
            this.gbCurrentInformation.Location = new System.Drawing.Point(12, 261);
            this.gbCurrentInformation.Name = "gbCurrentInformation";
            this.gbCurrentInformation.Size = new System.Drawing.Size(210, 151);
            this.gbCurrentInformation.TabIndex = 5;
            this.gbCurrentInformation.TabStop = false;
            this.gbCurrentInformation.Text = "General information";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(142, 123);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(58, 20);
            this.tbGenre.TabIndex = 8;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(50, 123);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(41, 20);
            this.tbYear.TabIndex = 7;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(50, 97);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(150, 20);
            this.tbAlbum.TabIndex = 6;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(50, 71);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(150, 20);
            this.tbArtist.TabIndex = 5;
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(50, 45);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(150, 20);
            this.tbFileName.TabIndex = 3;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(125, 19);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(75, 20);
            this.tbNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Genre:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(5, 126);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(32, 13);
            this.lbYear.TabIndex = 0;
            this.lbYear.Text = "Year:";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Location = new System.Drawing.Point(6, 100);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(39, 13);
            this.lbAlbum.TabIndex = 0;
            this.lbAlbum.Text = "Album:";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Location = new System.Drawing.Point(6, 74);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(33, 13);
            this.lbArtist.TabIndex = 0;
            this.lbArtist.Text = "Artist:";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(6, 48);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(30, 13);
            this.lbFileName.TabIndex = 0;
            this.lbFileName.Text = "Title:";
            // 
            // lbFileNr
            // 
            this.lbFileNr.AutoSize = true;
            this.lbFileNr.Location = new System.Drawing.Point(6, 22);
            this.lbFileNr.Name = "lbFileNr";
            this.lbFileNr.Size = new System.Drawing.Size(47, 13);
            this.lbFileNr.TabIndex = 0;
            this.lbFileNr.Text = "Number:";
            // 
            // gbCurrentFile
            // 
            this.gbCurrentFile.Controls.Add(this.tbCurrentGenre);
            this.gbCurrentFile.Controls.Add(this.tbCurrentYear);
            this.gbCurrentFile.Controls.Add(this.tbCurrentAlbum);
            this.gbCurrentFile.Controls.Add(this.tbCurrentArtist);
            this.gbCurrentFile.Controls.Add(this.tbCurrentFileName);
            this.gbCurrentFile.Controls.Add(this.tbCurrentFileNr);
            this.gbCurrentFile.Location = new System.Drawing.Point(228, 261);
            this.gbCurrentFile.Name = "gbCurrentFile";
            this.gbCurrentFile.Size = new System.Drawing.Size(163, 151);
            this.gbCurrentFile.TabIndex = 6;
            this.gbCurrentFile.TabStop = false;
            this.gbCurrentFile.Text = "Current file information";
            // 
            // tbCurrentArtist
            // 
            this.tbCurrentArtist.Location = new System.Drawing.Point(6, 71);
            this.tbCurrentArtist.Name = "tbCurrentArtist";
            this.tbCurrentArtist.Size = new System.Drawing.Size(150, 20);
            this.tbCurrentArtist.TabIndex = 11;
            // 
            // tbCurrentFileName
            // 
            this.tbCurrentFileName.Location = new System.Drawing.Point(6, 45);
            this.tbCurrentFileName.Name = "tbCurrentFileName";
            this.tbCurrentFileName.Size = new System.Drawing.Size(150, 20);
            this.tbCurrentFileName.TabIndex = 10;
            // 
            // tbCurrentFileNr
            // 
            this.tbCurrentFileNr.Location = new System.Drawing.Point(6, 19);
            this.tbCurrentFileNr.Name = "tbCurrentFileNr";
            this.tbCurrentFileNr.Size = new System.Drawing.Size(150, 20);
            this.tbCurrentFileNr.TabIndex = 9;
            // 
            // tbCurrentAlbum
            // 
            this.tbCurrentAlbum.Location = new System.Drawing.Point(6, 97);
            this.tbCurrentAlbum.Name = "tbCurrentAlbum";
            this.tbCurrentAlbum.Size = new System.Drawing.Size(150, 20);
            this.tbCurrentAlbum.TabIndex = 12;
            // 
            // tbCurrentYear
            // 
            this.tbCurrentYear.Location = new System.Drawing.Point(6, 123);
            this.tbCurrentYear.Name = "tbCurrentYear";
            this.tbCurrentYear.Size = new System.Drawing.Size(52, 20);
            this.tbCurrentYear.TabIndex = 13;
            // 
            // tbCurrentGenre
            // 
            this.tbCurrentGenre.Location = new System.Drawing.Point(64, 123);
            this.tbCurrentGenre.Name = "tbCurrentGenre";
            this.tbCurrentGenre.Size = new System.Drawing.Size(92, 20);
            this.tbCurrentGenre.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(428, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Location = new System.Drawing.Point(56, 229);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(528, 20);
            this.tbOutput.TabIndex = 2;
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(8, 232);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(42, 13);
            this.lbOutput.TabIndex = 3;
            this.lbOutput.Text = "Output:";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(509, 420);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAll.TabIndex = 16;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 454);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.gbCurrentFile);
            this.Controls.Add(this.gbCurrentInformation);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbFormat);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFormatLabel);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbFilepath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCurrentInformation.ResumeLayout(false);
            this.gbCurrentInformation.PerformLayout();
            this.gbCurrentFile.ResumeLayout(false);
            this.gbCurrentFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilepath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Label lbFormatLabel;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.TextBox tbFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCurrentInformation;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Label lbFileNr;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.GroupBox gbCurrentFile;
        private System.Windows.Forms.TextBox tbCurrentFileNr;
        private System.Windows.Forms.TextBox tbCurrentArtist;
        private System.Windows.Forms.TextBox tbCurrentFileName;
        private System.Windows.Forms.TextBox tbCurrentGenre;
        private System.Windows.Forms.TextBox tbCurrentYear;
        private System.Windows.Forms.TextBox tbCurrentAlbum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Button btnSaveAll;
    }
}

