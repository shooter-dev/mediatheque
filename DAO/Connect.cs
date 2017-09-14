using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class Connect
    {
        private string url = "shooterdev.hopto.org";
        private string database = "mangatheque";
        private string login = "";
        private string pwd = "";
        private string port = "3306";
        MySqlConnection msc;

        public Connect(){
            string cs = String.Format("server={0};userid={1};password={2};database={3}",url,login,pwd,database);

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
