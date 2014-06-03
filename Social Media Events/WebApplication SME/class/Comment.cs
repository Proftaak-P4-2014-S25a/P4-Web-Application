using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class Comment
	{
        public int CommentID { get; set; }
        public int RFID { get; set; }
        public int BestandID { get; set; }
        public DateTime Datum { get; set; }
        public string Opmerking { get; set; }

        public Comment()
        {

        }

	}
}