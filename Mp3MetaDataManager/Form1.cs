using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

using WindowsApplication12.Classes;

namespace Mp3MetaDataManager
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog dlg;
        private string currentFolder;
        private Mp3File[] fileArray;
        private Mp3File currentFile;

        public Form1()
        {
            this.dlg = new FolderBrowserDialog();
            this.dlg.Description = "Select the directory that you want to scan.";
            this.dlg.RootFolder = Environment.SpecialFolder.Personal;
            this.dlg.ShowNewFolderButton = false;

            InitializeComponent();
        }

        private void setCurrentFolder(string folderPath)
        {
            if (folderPath == null)
                return;

            if (!Directory.Exists(folderPath))
                return;

            this.tbFilepath.Text = folderPath;
            this.currentFolder = folderPath;
        }

        private void scanCurrentFolder()
        {
            string[] fileArray = Directory.GetFiles(this.currentFolder, "*.mp3");
            Mp3File file;

            this.fileArray = new Mp3File[fileArray.Length];
            this.lbFiles.Items.Clear();

            for (int i = 0; i < fileArray.Length; i++)
            {
                file = new Mp3File(fileArray[i]);

                this.lbFiles.Items.Add(file);
                this.fileArray[i] = file;
            }
        }

        private bool parseCurrentFileName()
        {
            string fileName;
            string format;

            try
            {
                format = this.tbFormat.Text;
                if (format.Contains("<nr>")) format = format.Replace("<nr>", "(?<nr>[0-9]{1,2})");
                if (format.Contains("<title>")) format = format.Replace("<title>", "(?<title>[_a-zA-Z0-9'\"`., \\-()]+)");
                if (format.Contains("<album>")) format = format.Replace("<album>", "(?<album>[_a-zA-Z0-9'\"`. ]+)");
                if (format.Contains("<artist>")) format = format.Replace("<artist>", "(?<artist>[_a-zA-Z0-9'\"`. ]+)");

                TextInfo TextInfo = new CultureInfo("en-US", false).TextInfo;
                // currentFile = (Mp3File)this.lbFiles.SelectedItem;
                fileName = currentFile.FileName;

                Regex rex = new Regex(format);
                if (rex.IsMatch(fileName))
                {
                    Match m = rex.Match(fileName);


                    currentFile.Number = m.Groups["nr"].Value;
                    currentFile.Title = m.Groups["title"].Value.Replace("_", " ");
                    currentFile.Artist = m.Groups["artist"].Value.Replace("_", " ");

                    currentFile.Title = TextInfo.ToTitleCase(currentFile.Title);
                    currentFile.Artist = TextInfo.ToTitleCase(currentFile.Artist);

                    currentFile.Album = this.tbAlbum.Text;
                    currentFile.Year = this.tbYear.Text;
                    currentFile.Genre = this.tbGenre.Text;

                    if (m.Groups["nr"].Value == String.Empty)
                    {
                        currentFile.Number = (this.lbFiles.SelectedIndex + 1).ToString();
                        if (currentFile.Number.Length == 1) currentFile.Number = "0" + currentFile.Number;
                    }

                    if (this.tbArtist.Text != String.Empty)
                        currentFile.Artist = this.tbArtist.Text;

                    if (this.tbAlbum.Text != String.Empty)
                        currentFile.Album = this.tbAlbum.Text;

                    this.tbCurrentFileNr.Text = currentFile.Number;
                    this.tbCurrentFileName.Text = currentFile.Title;
                    this.tbCurrentAlbum.Text = currentFile.Album;
                    this.tbCurrentArtist.Text = currentFile.Artist;
                    this.tbCurrentYear.Text = currentFile.Year;
                    this.tbCurrentGenre.Text = currentFile.Genre;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
        /*
        public void TestParseURL()
        {
            string url = "http://www.cambiaresearch.com"
               + "/Cambia3/snippets/csharp/regex/uri_regex.aspx?id=17#authority";

            string regexPattern = @"^(?<s1>(?<s0>[^:/\?#]+):)?(?<a1>"
               + @"//(?<a0>[^/\?#]*))?(?<p0>[^\?#]*)"
               + @"(?<q1>\?(?<q0>[^#]*))?"
               + @"(?<f1>#(?<f0>.*))?";

            Regex re = new Regex(regexPattern, RegexOptions.ExplicitCapture);
            Match m = re.Match(url);

            lblOutput.Text = "<b>URL: " + url + "</b><p>";

            lblOutput.Text +=
               m.Groups["s0"].Value + "  (Scheme without colon)<br>";
            lblOutput.Text +=
               m.Groups["s1"].Value + "  (Scheme with colon)<br>";
            lblOutput.Text +=
               m.Groups["a0"].Value + "  (Authority without //)<br>";
            lblOutput.Text +=
               m.Groups["a1"].Value + "  (Authority with //)<br>";
            lblOutput.Text +=
               m.Groups["p0"].Value + "  (Path)<br>";
            lblOutput.Text +=
               m.Groups["q0"].Value + "  (Query without ?)<br>";
            lblOutput.Text +=
               m.Groups["q1"].Value + "  (Query with ?)<br>";
            lblOutput.Text +=
               m.Groups["f0"].Value + "  (Fragment without #)<br>";
            lblOutput.Text +=
               m.Groups["f1"].Value + "  (Fragment with #)<br>";


        }
        */
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.setCurrentFolder(this.dlg.SelectedPath);
                this.scanCurrentFolder();
            }
        }

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbFiles.SelectedIndex == -1)
                return;

            this.tbCurrent.Text = this.lbFiles.SelectedItem.ToString();
            this.currentFile = (Mp3File)this.lbFiles.SelectedItem;



            this.parseCurrentFileName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.parseCurrentFileName())
                return;

            Mp3File currentFile = (Mp3File)this.lbFiles.SelectedItem;
            currentFile.Save(this.tbOutput.Text);

            int i = this.lbFiles.SelectedIndex;
            this.scanCurrentFolder();
            this.lbFiles.SelectedIndex = i;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbOutput.Text = "<nr> - <album> - <artist> - <title>.mp3";
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            foreach (Mp3File file in this.fileArray)
            {
                this.currentFile = file;
                this.parseCurrentFileName();
                file.Save(this.tbOutput.Text);
            }            

            string newFolder = Directory.GetParent(currentFolder) + "\\" + String.Format("{0} - {1}", this.tbArtist.Text, this.tbAlbum.Text);
            if (this.tbArtist.Text != String.Empty && this.tbAlbum.Text != String.Empty)
                Directory.Move(this.currentFolder, newFolder);
        }
    }
}