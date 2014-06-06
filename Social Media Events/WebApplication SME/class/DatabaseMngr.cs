//DatabaseMngr Code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Web.Configuration;
using System.Configuration;

namespace WebApplication_SME
{
    public class DatabaseMngr
    {
        private OracleConnection conn;

        public DatabaseMngr()
        {
            conn = new OracleConnection();
        }

        private void open()
        {
            try
            {

                conn.ConnectionString = "User Id= sme; Password= password; Data Source= 192.168.19.163:1521;";
                conn.Open();
            }
            catch
            { }
        }

        private void close()
        {
            try
            {
                conn.Close();
            }
            catch { }
        }

        public bool AuthenticateLogin(string rfid, string password)
        {
            //try
            //{
                open();
                OracleCommand cmd = new OracleCommand("CHECKLOGIN", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("v_result", OracleDbType.Varchar2, ParameterDirection.ReturnValue));
                cmd.Parameters.Add("P_RFID", OracleDbType.Varchar2, rfid, ParameterDirection.Input);
                cmd.Parameters.Add("P_PASS", OracleDbType.Varchar2, password, ParameterDirection.Input);
                

                cmd.ExecuteNonQuery();

                string auth = cmd.Parameters["v_result"].Value.ToString();

                close();
                if(auth == "true")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            //}
            //catch { }
            //finally{ conn.Close(); }
        }

        public int GetMaxRFID()
        {
            //try
            //{
            open();
            OracleCommand cmd = new OracleCommand("GETFREERFID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new OracleParameter("v_result", OracleDbType.Varchar2, 500, ParameterDirection.ReturnValue));

            cmd.ExecuteNonQuery();

            string auth = cmd.Parameters["v_result"].Value.ToString();

            return Convert.ToInt32(auth);
            //}
            //catch { }
        }

        public string GetEmail(int RFID)
        {
            throw new NotImplementedException();
        }
    }
}