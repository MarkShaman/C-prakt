using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class BreakableWall(int durability) : IDamageable
    {
        public int Durability { get; private set; } = durability;

        public void TakeDamage(int damage)
        {
            Durability -= damage;
            Console.WriteLine($"Wall took {damage} damage. Remaining durability: {Durability}");

            if (Durability <= 0)
            {
                Console.WriteLine("Wall has been broken.");
            }
        }
    }
}
