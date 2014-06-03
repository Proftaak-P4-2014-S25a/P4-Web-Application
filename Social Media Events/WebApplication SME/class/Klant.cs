using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class Klant:Persoon
	{
        public int ReservationNumber { get; set; }

        public Klant(int rfid, string password,int reservationnumber):base(rfid,password)
        {
            this.ReservationNumber = reservationnumber;
        }

        public override string ToString()
        {
            return base.ToString() + " " + "ReservationNumber: " + this.ReservationNumber + " ";
                                     
        }
	}
}