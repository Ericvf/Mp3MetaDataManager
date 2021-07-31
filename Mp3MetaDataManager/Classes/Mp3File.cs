using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WindowsApplication12.Classes
{
    enum Shell32DetailColumns
	{
		InfoTip = -1,

		Name = 0,
		Size = 1,
		Type = 2,

		DateLastModified = 3,
		DateCreated = 4,
		DateLastAccessed = 5,

		Attributes = 6,
		Status = 7,
		Owner = 8,
		
		Author = 9,
		Title = 10,
		Subject = 11,
		Category = 12,
		Pages = 13,
		Comments = 14,

		Artist = 16,
		AlbumTitle = 17,
		Year = 18,
		TrackNumber = 19,
		Genre = 20,
		Duration = 21,
		Bitrate = 22,
		Protected = 23,

		Dimensions = 26,
		Width = 27,
		Height = 28,

        Company = 30,
		Description = 31,
		FileVersion = 32,
		ProductName = 33,
		ProductVersion = 34
	}

    class Mp3File
    {
        private FileInfo fileInfo;
        private string number;
        private string title;
        private string artist;
        private string album;
        private string year;
        private string genre;

        public Mp3File(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            this.fileInfo = new FileInfo(filePath);
        }

        public string FileName
        {
            get { return this.fileInfo.Name; }
            set { this.SetFileName(value); }
        }

        private void SetFileName(string value)
        {
            string filepath = this.fileInfo.DirectoryName + "\\" + value;
            File.Move(this.fileInfo.FullName, filepath);
            this.fileInfo = new FileInfo(filepath);
        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Artist
        {
            get { return this.artist; }
            set { this.artist = value; }
        }

        public string Album
        {
            get { return this.album; }
            set { this.album = value; }
        }

        public string Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }

        public void Save(string output)
        {
            if (output.Contains("<nr>")) output = output.Replace("<nr>", this.Number);
            if (output.Contains("<title>")) output = output.Replace("<title>", this.Title);
            if (output.Contains("<artist>")) output = output.Replace("<artist>", this.Artist);
            if (output.Contains("<album>")) output = output.Replace("<album>", this.Album);

            this.FileName = output;
        }

        public void ReadID3Tags()
        {
            Shell32.Shell shell = new Shell32.ShellClass();
            Shell32.Folder folder = shell.NameSpace(this.fileInfo.Directory);
            Shell32.FolderItem folderItem = folder.ParseName(this.FileName);

            if (folderItem != null)
            {
                /*

                this.Artist = folder.GetDetailsOf(folderItem, Shell32DetailColumns.Author);
                this.Album  = folder.GetDetailsOf(folderItem, Shell32DetailColumns.AlbumTitle);
                this.Title  = folder.GetDetailsOf(folderItem, Shell32DetailColumns.Title);
                this.Number = folder.GetDetailsOf(folderItem, Shell32DetailColumns.TrackNumber);
                 * 
                 * */
            }
        }

        public override string ToString()
        {
            return this.FileName;
        }
    }
}
