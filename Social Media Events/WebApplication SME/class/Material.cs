using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class Material
	{
        private string type;
        private double price;
        private int amount;

        public string Type
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public Material(string type, double price, int amount)
        {
            this.Type = type;
            this.Price = price;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return "Type: " + Type + " Price: " + Price + " Amount: " + Amount + "";
        }
	}
}