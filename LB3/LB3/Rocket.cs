using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class Rocket(int damage) : Projectile(damage)
    {
        public override void HitTarget(IDamageable target)
        {
            int randomDamage = new Random().Next(damage - 5, damage + 5); // Випадкова кількість пошкоджень
            Console.WriteLine($"Rocket hits with {randomDamage} damage.");
            target.TakeDamage(randomDamage);
        }
    }
}
