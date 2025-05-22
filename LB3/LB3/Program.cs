using System.Net.Sockets;
using System;

namespace LB3
{
    class Program
    {
        static void Main()
        {
            var enemy = new Enemy(50);
            var armoredEnemy = new ArmoredEnemy(50, 10);
            var wall = new BreakableWall(30);

            var bullet = new Bullet(20);
            var rocket = new Rocket(40);

            Console.WriteLine("Firing Bullet at Enemy...");
            bullet.HitTarget(enemy);

            Console.WriteLine("\nFiring Bullet at Armored Enemy...");
            bullet.HitTarget(armoredEnemy);

            Console.WriteLine("\nFiring Bullet at Wall...");
            bullet.HitTarget(wall);

            Console.WriteLine("\nFiring Rocket at Enemy...");
            rocket.HitTarget(enemy);

            Console.WriteLine("\nFiring Rocket at Armored Enemy...");
            rocket.HitTarget(armoredEnemy);

            Console.WriteLine("\nFiring Rocket at Wall...");
            rocket.HitTarget(wall);
        }
    }
}