using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class RegularUser(string userName, string email) : User(userName, email)
    {
        public void PostComment()
        {
            Console.WriteLine("Коментар опубліковано.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Роль: Звичайний користувач");
        }
    }
}
