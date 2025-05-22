using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class ArmoredEnemy : Enemy
    {
        public int Armor { get; private set; }

        public ArmoredEnemy(int health, int armor) : base(health)
        {
            Armor = armor;
        }

        public override void TakeDamage(int damage)
        {
            int damageAfterArmor = Math.Max(0, damage - Armor);
            base.TakeDamage(damageAfterArmor);
        }
    }
}
