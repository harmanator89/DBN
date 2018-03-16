using System;
using System.Collections.Generic;
using System.Text;

namespace DBN.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {

            Console.WriteLine("Username: ", Username);
            Console.WriteLine("Password:", Password);



            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;

        }
    }
}
