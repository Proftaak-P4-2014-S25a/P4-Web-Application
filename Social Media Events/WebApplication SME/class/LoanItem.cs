using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class LoanItem
    {

        #region Properties
        public int Reservationnumber
        {
            get;
            set;
        }

        public List<Material> Materials
        {
            get;
            set;
        }

        public DateTime LoanDate
        {
            get;
            set;
        }

        public DateTime ReturnDate
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
        public LoanItem(int reservationnumber, DateTime loandate, DateTime returndate)
        {
            this.Reservationnumber = reservationnumber;
            this.LoanDate = loandate;
            this.ReturnDate = returndate;
        }

        #endregion

        #region Methods
        public void AddMaterial(Material material)
        {
            Materials.Add(material);
        }

        public override string ToString()
        {
            return "Reservationnumber: "+Reservationnumber+" Loan Date: "+LoanDate+" Return Date: "+ReturnDate+" Amount: "+Amount;
        }
        #endregion
    }
}