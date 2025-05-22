using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class User(string userName, string email)
    {
        public string UserName { get; set; } = userName;
        public string Email { get; set; } = email;

        private string _password = string.Empty;

        public void SetPassword(string newPassword)
        {
            _password = newPassword;
        }

        public bool Authenticate(string inputPassword)
        {
            return _password == inputPassword;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Ім'я: {UserName} | Email: {Email}");
        }
    }
}
