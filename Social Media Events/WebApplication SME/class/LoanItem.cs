using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class LoanItem
	{
        private int reservationnumber;
        private List<Material> materials;
        private DateTime loanDate;
        private DateTime returnDate;
        private int amount;

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

        public LoanItem(int reservationnumber, DateTime loandate, DateTime returndate)
        {
            this.Reservationnumber = reservationnumber;
            this.LoanDate = loandate;
            this.ReturnDate = returndate;
        }

        public void AddMaterial(Material material)
        {
            Materials.Add(material);
        }

        public override string ToString()
        {
            return "Reservationnumber: "+Reservationnumber+" Loan Date: "+LoanDate+" Return Date: "+ReturnDate+" Amount: "+Amount;
        }
	}
}