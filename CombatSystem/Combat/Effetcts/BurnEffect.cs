using CombatSystem.Characters;
using CombatSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Combat.Effetcts
{
    internal class BurnEffect : IEffect
    {
        public string EffectName => "Burn";

        public void ApplyEffect(Character target)
        {
            Console.WriteLine($"{target.Name} is burning! takes 10 extra damage from fire.");
            target.TakeDamage(10);
        }
    }
}
