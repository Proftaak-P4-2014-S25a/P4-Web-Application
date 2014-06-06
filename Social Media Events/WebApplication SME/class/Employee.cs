using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class Medewerker:Persoon
    {
        #region Properties
        public string Name { get; set; }
        public string Function { get; set; }
        public int Bankaccount { get; set; }
        #endregion

        #region Constructor
        public Medewerker(int rfid, string password,string name,string function,int bankaccount):base(rfid,password)
        {
            this.Name = name;
            this.Function = function;
            this.Bankaccount = bankaccount;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + " " + "Name: " + this.Name + " " +
                                        "Function: " + this.Function + " " +
                                        "Bankaccount: " + this.Bankaccount + " ";
        }
        #endregion
    }
}