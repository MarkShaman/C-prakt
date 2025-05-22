using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class Moderator(string userName, string email) : User(userName, email)
    {
        public void ModerateContent()
        {
            Console.WriteLine("Контент модеровано.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Роль: Модератор");
        }
    }
}
