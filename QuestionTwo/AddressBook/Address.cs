using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AddressBook
{
    internal class Address
    {
        private string name;
        private string email;
        private string phone;

        public Address(string name, string email, string phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public bool Save()
        {
            try
            {
                MySqlCommand command;
                ConnectDB.openConnection();
                string query = "insert into address(name, email, phone) values('"+this.name+"', '"+this.email+"', '"+this.phone+"')";
                command = new MySqlCommand(query, ConnectDB.connection);
                command.ExecuteNonQuery();
                ConnectDB.closeConnection();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
