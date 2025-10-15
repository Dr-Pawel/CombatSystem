using CombatSystem.Characters;
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
        public MagicAttack(string name, int damageAmount, IEffect? effect = null)
        {
            this.AttackName = name;
            this.DamageAmount = damageAmount;
            Effect = effect;
        }

        public override void ExecuteAttack(IDamageable target)
        {
            if (target is not Character targetCharacter)
            {
                Console.WriteLine("Target cannot be attacked — it's not a Character!");
                return;
            }
            target.TakeDamage(DamageAmount);
            Console.WriteLine($"Magic attack: {AttackName} deals {DamageAmount}.");
            Effect?.ApplyEffect(targetCharacter);
        }
    }
}
