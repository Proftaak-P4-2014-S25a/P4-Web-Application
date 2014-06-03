using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public abstract class Persoon
	{
        public int RFID { get; set; }
        public string Password { get; set; }

       public Persoon(int rfid,string password)
        {
            this.RFID = rfid;
            this.Password = password;
       }

       public override string ToString()
       {
           return "RFID: " + this.RFID + " " + "wachtwoord: " + Password;
       }
   
   
    
	}
}