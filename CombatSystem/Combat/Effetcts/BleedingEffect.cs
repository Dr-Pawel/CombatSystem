using CombatSystem.Characters;
using CombatSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Combat.Effetcts
{
    internal class BleedingEffect : IEffect
    {
        public string EffectName => "Bleeding";

        public void ApplyEffect(Character target)
        {
            Console.WriteLine($"{target.Name} is bleeding! takes 15 extra damage from open wound.");
            target.TakeDamage(15);
        }
    }
}
