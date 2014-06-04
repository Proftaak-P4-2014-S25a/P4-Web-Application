using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class ReservationItem
	{
        private int reservationnumber;
        private Campingspot campingspot;
        private bool hasBeenPaid;

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

        public ReservationItem(int reservation, Campingspot campingspot, bool hasBeenPaid)
        {
            this.Reservationnumber = reservation;
            this.Campingspot = campingspot;
            this.HasBeenPaid = hasBeenPaid;
        }

        public override string ToString()
        {
            return "Reservationnumber: " + Reservationnumber + " Campingplace: " + Campingspot;
        }
	}
}