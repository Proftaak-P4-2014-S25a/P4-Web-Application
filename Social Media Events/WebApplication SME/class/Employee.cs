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
        public string Bankaccount { get; set; }
        #endregion

        #region Constructor
        public Medewerker(int rfid, string password,string name,string function,string bankaccount):base(rfid,password)
        {
            this.Name = name;
            this.Function = function;
            this.Bankaccount = bankaccount;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + "Name: " + this.Name +  Environment.NewLine+
                                        "Function: " + this.Function + Environment.NewLine +
                                        "Bankaccount: " + this.Bankaccount + Environment.NewLine;
        }
        #endregion
    }
}