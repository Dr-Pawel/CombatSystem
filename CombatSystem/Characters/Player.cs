using CombatSystem.Combat;
using CombatSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Characters
{
    public class Player : Character, IHealable
    {
        List<Attack> Attacks = new List<Attack>();
    
        public Player(string name, int maxHealth)
        {
            this.Name = name;
            SetMaxHealth(maxHealth);
            Attacks.Add(AttackFactory.CreateFireball());
            Attacks.Add(AttackFactory.CreateLightningStrike());
            Attacks.Add(AttackFactory.CreateSwordSlash());
            Console.WriteLine($"new Player of name {name} has been created. \n");

        }

        public void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth >= MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            Console.WriteLine($"{Name} healed for {amount}. Current HP: {CurrentHealth}/{MaxHealth}");
        }

        public void Attack(IDamageable target)
        {
            Console.WriteLine($"Player {this.Name} is attacking...");

            while (true)
            {
                Console.WriteLine("\nChoose attack you want to use:");
                ShowCharacterAttacks();
                Console.Write("Enter attack number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int index))
                {
                    index -= 1;
                    if (index >= 0 && index < Attacks.Count)
                    {
                        Console.WriteLine($"\nYou chose {Attacks[index].AttackName}!");

                        Attacks[index].ExecuteAttack(target);

                        if (target is Character targetCharacter)
                        {
                            Console.WriteLine($"{targetCharacter.Name} lost {Attacks[index].DamageAmount} health.");
                            Console.WriteLine($"{targetCharacter.Name} current HP : {targetCharacter.CurrentHealth}/{targetCharacter.MaxHealth}"); ;
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("❌ Invalid choice! Please enter a number from the list.");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Please enter a valid number!");
                }
            }
        }

        public void ShowCharacterAttacks()
        {
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Attacks[i].AttackName} (Damage: {Attacks[i].DamageAmount})");
            }
        }
    }
}
