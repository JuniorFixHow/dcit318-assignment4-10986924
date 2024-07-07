using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AddressBook
{
    internal class ConnectDB
    {
        private static string connnectionString = "server=localhost; database=dcit; uid=root; pwd=";
        public static MySqlConnection connection = new MySqlConnection(connnectionString);

        public static void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    Console.Write("Opened");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured trying to connect to the database!");
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured trying to close connection!");
            }
        }
    }
}
