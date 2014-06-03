using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
    public class Campingspot
    {
        #region Fields
        private int placenumber;
        private int coordinateX;
        private int coordinateY;
        private double price;
        private string comment;
        #endregion

        #region Properties
        public int Placenumber
        {
            get;
            set;
        }

        public int CoordinateX
        {
            get;
            set;
        }

        public int CoordinateY
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public string Comment
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public Campingspot(int placenumber, int coordinateX, int coordinateY, double price, string comment)
        {
            this.Placenumber = placenumber;
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.Price = price;
            this.Comment = comment;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return "Placenumber: " + Placenumber + " CoordintaX: " + CoordinateX + " CoordinateY: " + CoordinateY + " Price: " + Price + " Comment: " + Comment + "";
        }

        #endregion
    }
}