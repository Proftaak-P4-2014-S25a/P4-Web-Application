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

        private void Open()
        {
            try
            {

                conn.ConnectionString = "User Id= sme; Password= password; Data Source= 192.168.19.163:1521;";
                conn.Open();
            }
            catch
            { }
        }

        public bool AuthenticateLogin(string rfid, string password)
        {
            try
            {
                Open();
                OracleCommand cmd = new OracleCommand("CHECKLOGIN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter("v_result", OracleDbType.Varchar2, 500));
                cmd.Parameters["v_result"].Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add("P_RFID", OracleDbType.Varchar2, rfid, ParameterDirection.Input);
                cmd.Parameters.Add("P_PASS", OracleDbType.Varchar2, password, ParameterDirection.Input);
                cmd.ExecuteNonQuery();
                string auth = cmd.Parameters["v_result"].Value.ToString();
                if (auth == "true")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { }
            finally { conn.Close(); }
            return false;
        }
    

        public int GetMaxRFID()
        {
            try
            {
                Open();
                OracleCommand cmd = new OracleCommand("GETMAXRFID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("v_result", OracleDbType.Varchar2, 500));
                cmd.Parameters["v_result"].Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();

            string auth = cmd.Parameters["v_result"].Value.ToString();

            return Convert.ToInt32(auth);
            }
            catch { }
            finally { conn.Close(); }
            return -1;
        }

        public string GetEmail(int rfid)
        {
            try
            {
                Open();
                OracleCommand cmd = new OracleCommand("GETEMAILFROMKLANTBETALEND", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("P_RFID", OracleDbType.Int32, rfid, ParameterDirection.Input);

                cmd.Parameters.Add(new OracleParameter("V_EMAIL", OracleDbType.Varchar2, 500));
                cmd.Parameters["V_EMAIL"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                string auth = cmd.Parameters["V_EMAIL"].Value.ToString();

                return auth;
            }
            catch { }
            finally { conn.Close(); }
            return null;
           
        }

        public List<Material> GetMaterials()
        {
            List<Material> list = new List<Material>();
            try
            {
                Open();
                OracleCommand cmd = new OracleCommand("GetAlleMaterialen", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("v_materials", OracleDbType.RefCursor, 500)).Direction = ParameterDirection.Output;

                OracleDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    list.Add(new Material(Convert.ToString(reader["TYPE"]),
                        Convert.ToDouble(reader["Verhuurprijs"]),
                        Convert.ToInt32(reader["Aantal"])));
                       
                }
            }
            catch 
            { 
            }
            finally { conn.Close(); }
            return list;
        }

        public List<int> GetFreeCampsites()
        {
            List<int> list = new List<int>();
            try
            {
                Open();
                OracleCommand cmd = new OracleCommand("GETCAMPINGSPOTS", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter("V_NUMBER", OracleDbType.RefCursor, 500)).Direction = ParameterDirection.Output;

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(Convert.ToInt32(reader.GetOracleString(0).ToString()));
                }
            }
            catch { }
            finally { conn.Close(); }
            return list;
        }

        public void UpdateMateriaal(string materiaalnaam,int amount)
        {
            try
            {
                Open();
                OracleCommand cmd = new OracleCommand("UPDATEMATERIAL", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("P_materiaalnaam", OracleDbType.Varchar2, materiaalnaam, ParameterDirection.Input);
                cmd.Parameters.Add("p_amount", OracleDbType.Varchar2, amount, ParameterDirection.Input);
                cmd.ExecuteNonQuery();
                           
            }
            catch { }
            finally { conn.Close(); }
           

        }
    }
}