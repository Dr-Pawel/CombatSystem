using CombatSystem.Characters;
using CombatSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Combat.Effetcts
{
    internal class LightningEffect : IEffect
    {
        public string EffectName => "Lightning";

        public void ApplyEffect(Character target)
        {
            Console.WriteLine($"{target.Name} is shocked! takes 5 extra damage from Lightning.");
            target.TakeDamage(5);
        }
    }
}
