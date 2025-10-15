using CombatSystem.Characters;
using CombatSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Combat
{
    internal abstract class Attack
    {
        public string AttackName { get; set; }
        public int DamageAmount { get; set; }
        public IEffect? Effect { get; set; }

        public abstract void ExecuteAttack(IDamageable target);
    }
}
