using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class Enemy(int health) : IDamageable
    {
        public int Health { get; protected set; } = health;

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"Enemy took {damage} damage. Remaining health: {Health}");

            if (Health <= 0)
            {
                Console.WriteLine("Enemy has been destroyed.");
            }
        }
    }
}
