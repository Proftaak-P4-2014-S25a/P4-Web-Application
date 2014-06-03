using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
    public class Campingspot
    {
        private int placenumber;
        private int coordinateX;
        private int coordinateY;
        private double price;
        private string comment;

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

        public Campingspot(int placenumber, int coordinateX, int coordinateY, double price, string comment)
        {
            this.Placenumber = placenumber;
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.Price = price;
            this.Comment = comment;
        }

        public override string ToString()
        {
            return "Placenumber: " + Placenumber + " CoordintaX: " + CoordinateX + " CoordinateY: " + CoordinateY + " Price: " + Price + " Comment: " + Comment + "";
        }
    }
}