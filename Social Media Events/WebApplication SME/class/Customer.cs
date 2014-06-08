using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class Klant:Persoon
    {
        #region Properties
        public int ReservationNumber { get; set; }
        #endregion

        #region Constructor
        public Klant(int rfid, string password,int reservationnumber):base(rfid,password)
        {
            this.ReservationNumber = reservationnumber;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + "ReservationNumber: " + this.ReservationNumber + Environment.NewLine;

        }
        #endregion
    }
}