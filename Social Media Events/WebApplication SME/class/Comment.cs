using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class Comment
	{
        public int RFID { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        public Comment(int rfid,DateTime date,string comment)
        {
            this.RFID = rfid;
            this.Date = date;
            this.Comment = comment;
        }

        public override string ToString()
        {
            return "RFID: " + this.RFID +
                " Datum: " + this.Date +
                " Opmerking: " + this.Comment;
        }
	}
}