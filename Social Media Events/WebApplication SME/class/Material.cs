using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class Material
    {

        #region Properties
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
        #endregion

        #region Constructor
        public Material(string type, double price, int amount)
        {
            this.Type = type;
            this.Price = price;
            this.Amount = amount;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Type: " + Type + " Price: " + Price + " Amount: " + Amount + "";
        }
        #endregion
    }
}