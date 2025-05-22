using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class Bullet(int damage) : Projectile(damage)
    {
        public override void HitTarget(IDamageable target)
        {
            Console.WriteLine($"Bullet hits with {damage} damage.");
            target.TakeDamage(damage);
        }
    }
}
