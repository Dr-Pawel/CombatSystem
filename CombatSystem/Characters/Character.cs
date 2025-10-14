using CombatSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Characters
{
    public abstract class Character : IDamageable
    {
        public string Name { get; set; }
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; set; }

        public void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
            if(CurrentHealth <= 0)
            {
                Console.WriteLine($"Character {Name} has been defeated");
            }
        }

        public void SetMaxHealth(int maxHealth)
        {
            this.MaxHealth = maxHealth;
            this.CurrentHealth = maxHealth;
        }
    }
}
