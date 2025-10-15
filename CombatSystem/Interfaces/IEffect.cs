using CombatSystem.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Interfaces
{
    internal interface IEffect
    {
        string EffectName { get; }
        void ApplyEffect(Character target);
    }
}
