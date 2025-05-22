using System;
using System.Text;
namespace LB2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<User> users =
            [
                new Admin("AdminUser", "admin@example.com"),
            new Moderator("ModUser", "mod@example.com"),
            new RegularUser("RegUser", "user@example.com")
            ];

            users[0].SetPassword("admin123");
            users[1].SetPassword("mod123");
            users[2].SetPassword("user123");

            Console.WriteLine("\n=== Інформація про користувачів ===");
            foreach (var user in users)
            {
                user.DisplayInfo();
            }

            Console.WriteLine("\n=== Тестування методів ===");
            foreach (var user in users)
            {
                if (user is Admin admin)
                {
                    admin.BlockUser(users[2]);
                }
                else if (user is Moderator moderator)
                {
                    moderator.ModerateContent();
                }
                else if (user is RegularUser regularUser)
                {
                    regularUser.PostComment();
                }
            }

            Console.WriteLine("\n=== Перевірка аутентифікації ===");
            Console.WriteLine($"AdminUser: {(users[0].Authenticate("admin123") ? "Успішна аутентифікація" : "Невірний пароль")}");
            Console.WriteLine($"ModUser: {(users[1].Authenticate("wrongpass") ? "Успішна аутентифікація" : "Невірний пароль")}");
            Console.WriteLine($"RegUser: {(users[2].Authenticate("user123") ? "Успішна аутентифікація" : "Невірний пароль")}");
        }
    }
}