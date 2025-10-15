using CombatSystem.Combat;
using CombatSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Characters
{
    public class Enemy : Character
    {
        List<Attack> Attacks = new List<Attack>();
        private static readonly Random random = new Random();

        public Enemy(string name, int maxHealth)
        {
            this.Name = name;
            SetMaxHealth(maxHealth);
            Attacks.Add(AttackFactory.CreateBite());
            Attacks.Add(AttackFactory.CreateBloodDrain());
            Console.WriteLine($"new Enemy of name {name} has been created. \n");
        }

        public void Attack(IDamageable target)
        {
            if (target is not Character targetCharacter)
            {
                Console.WriteLine("Target cannot be attacked — it's not a Character!");
                return;
            }

            if (targetCharacter.CurrentHealth <= 0)
            {
                Console.WriteLine($"{targetCharacter.Name} is already defeated!");
                return;
            }

            int index = random.Next(Attacks.Count);
            var chosenAttack = Attacks[index];

            Console.WriteLine($"\n{this.Name} uses {chosenAttack.AttackName}!");
            chosenAttack.ExecuteAttack(targetCharacter);

            Console.WriteLine($"{targetCharacter.Name} current HP : {CurrentHealth}/{MaxHealth}");
        }
    }
}
