//DatabaseMngr Code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_SME
{
    public class DatabaseMngr
    {
        public DatabaseMngr()
        {

        }

        public bool AuthenticateLogin(int rfid, string password)
        {
            return true;
        }

        public int GetMaxRFID()
        {
            return 301;
        }

        public string GetUser(int RFID)
        {
            if(RFID == 300)
            {
                return "Spartacus";
            }
            return "TEST";
        }
    }
}