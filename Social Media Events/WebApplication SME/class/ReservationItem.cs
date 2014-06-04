using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class ReservationItem
    {

        #region Properties
        public int Reservationnumber
        {
            get;
            set;
        }

        public Campingspot Campingspot
        {
            get;
            set;
        }

        public bool HasBeenPaid
        {
            get;
            set;
        }
        #endregion

        #region Constructor

        public ReservationItem(int reservation, Campingspot campingspot, bool hasBeenPaid)
        {
            this.Reservationnumber = reservation;
            this.Campingspot = campingspot;
            this.HasBeenPaid = hasBeenPaid;
        }

        #endregion

        #region Methods 
        public override string ToString()
        {
            return "Reservationnumber: " + Reservationnumber + " Campingplace: " + Campingspot;
        }
        #endregion
    }
}