using CombatSystem.Characters;
using CombatSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CombatSystem.Combat
{
    internal class PhysicalAttack : Attack
    {
        public PhysicalAttack(string name, int damageAmount)
        {
            this.AttackName = name;
            this.DamageAmount = damageAmount;
        }

        public override void ExecuteAttack(IDamageable target)
        {
            target.TakeDamage(DamageAmount);
        }
    }
}
