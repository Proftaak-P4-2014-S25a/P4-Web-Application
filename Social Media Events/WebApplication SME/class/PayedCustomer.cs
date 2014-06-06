using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
	public class KlantBetalend:Persoon
    {
        #region Properties
        public string Name { get; set; }
        public string Street { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Bankaccount { get; set; }
        public string Sofinummer { get; set; }
        public int ReservationNumber { get; set; }
        #endregion

        #region Constructor
        public KlantBetalend(int rfid, string password, string name, string street, string postalcode, string city, string phonenumber, string email, int bankaccount, string sofinummer, int reservationnumber)
            : base(rfid, password)
        {
            this.Name = name;
            this.Street = street;
            this.Postalcode = postalcode;
            this.City = city;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.Bankaccount = bankaccount;
            this.Sofinummer = sofinummer;
            this.ReservationNumber = reservationnumber;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return base.ToString() + " " + "Name: " + this.Name + " " +
                                        "street: " + this.Street + " " +
                                        "postalcode: " + this.Postalcode + " " +
                                        "city: " + this.City + " " +
                                        "phonenumber: " + this.PhoneNumber + " " +
                                        "email: " + this.Email + " " +
                                        "bankaccount" + this.Bankaccount + " " +
                                        "sofinumber" + this.Sofinummer + " " +
                                        "reservationnumber" + this.ReservationNumber + " ";
        }
        #endregion
    }
}