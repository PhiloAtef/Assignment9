using Assignment9.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        string[] _users = { "Ahmed","Hambozo","Mahmoud" };
        int[] _passwords = { 1, 2, 3 };
        private string[] _roles =  { "Admin", "User","User" };

        public bool AuthenticateUser(string username, int password)
        {
            for (int i = 0; i < _users.Length; i++)
            {
                if (_users[i] == username && _passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < _users.Length; i++)
            {
                if (_users[i] == username && _roles[i] == role)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
