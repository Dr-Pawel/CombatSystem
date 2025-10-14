using CombatSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Combat
{
    internal class MagicAttack : Attack
    {
        public MagicAttack(string name, int damageAmount)
        {
            this.AttackName = name;
            this.DamageAmount = damageAmount;
        }

        public override void ExecuteAttack(IDamageable target)
        {
            target.TakeDamage(DamageAmount);
            Console.WriteLine($"Magic {AttackName} deals {DamageAmount}.");
        }
    }
}
