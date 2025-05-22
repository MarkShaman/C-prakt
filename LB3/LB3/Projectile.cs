using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public abstract class Projectile(int damage)
    {
        protected int damage = damage;

        public abstract void HitTarget(IDamageable target);
    }
}
