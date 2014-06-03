using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class File
    {
        #region Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public int RFID { get; set; }
        public DateTime Date { get; set; }
        public int Downloaded { get; set; }
        public int Rating { get; set; }
        public string Path { get; set; }
        public int ImgIndex { get; set; }
        public List<Comment> Comments { get; set; }
        #endregion

        #region Constructor
        public File(string name,string description,string extension,int size,int rfid,DateTime date,int downloaded,int rating,string path,int imgindex)
        {
            this.Name = name;
            this.Description = description;
            this.Extension = extension;
            this.Size = size;
            this.RFID = rfid;
            this.Date = date;
            this.Downloaded = downloaded;
            this.Rating = rating;
            this.Path = path;
            this.ImgIndex = imgindex;

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Name: " + this.Name +
                    " Description: " + this.Description +
                    " Extension: " + this.Extension +
                    " Size: " + this.Size +
                    " RFID: " + this.RFID +
                    " Date: " + this.Date +
                    " Downloaded: " + this.Downloaded +
                    " Rating: " + this.Rating +
                    " Path: " + this.Path +
                    " ImgIndex: " + this.ImgIndex;

        }

        public void AddComment(Comment comment)
        {
            this.Comments.Add(comment);
        }
        #endregion
    }
}