using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginApp
{
    public class Users
    {
        public string _Username { get; set; }
        public string _Password { get; set; }

        private string[] validUsers = { "Gabriel" };

        private string[] validPasswords = { "gabriel1234" };

        public Users(string username, string password)
        {
            UserValidation(username, password);
        }
        public void UserValidation(string username, string password)
        {
            foreach (var user in validUsers)
            {
                if (user == username)
                {
                    _Username = username;
                }
            }
            foreach (var pass in validPasswords)
            {
                if (pass == password)
                {
                    _Password = password;
                }
            }
        }
    }
}
