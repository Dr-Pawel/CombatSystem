using CombatSystem.Characters;
using System;
using System.Numerics;

namespace CombatSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create characters (example)
            Player player = new Player("Hero", 100);
            // assing attacks using AttackFactory and Player Contructor
            // player.Attacks.Add(AttackFactory.CreateSwordSlash());


            Enemy enemy = new Enemy("Ghoul", 80);
            // enemy is preparing attacks in his contrucotr


            Console.WriteLine("\n=== Combat start ===\n");

            while (player.CurrentHealth > 0 && enemy.CurrentHealth > 0)
            {
                // ========== Player turn ==========
                Console.WriteLine($"\n--- {player.Name}'s turn ---");
                bool playerEndedTurn = false;

                while (!playerEndedTurn)
                {
                    Console.WriteLine("\nChoose action:");
                    Console.WriteLine("1. Attack");
                    Console.WriteLine("2. Heal");
                    Console.WriteLine("3. Show attacks");
                    Console.WriteLine("4. Show status");
                    Console.WriteLine("5. Surrender (end fight)");
                    Console.Write("Your choice: ");

                    var input = Console.ReadLine()?.Trim();

                    switch (input)
                    {
                        case "1": // Attack
                                  // player.Attack handles input/choice of attack inside itself (as we designed)
                            player.Attack(enemy); // passing enemy (IDamageable) is ok
                            playerEndedTurn = true;
                            break;

                        case "2": // Heal
                            Console.Write("Enter heal amount: ");
                            if (int.TryParse(Console.ReadLine(), out int healAmount) && healAmount > 0)
                            {
                                player.Heal(healAmount);
                                playerEndedTurn = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid heal amount.");
                            }
                            break;

                        case "3": // Show attacks
                            player.ShowCharacterAttacks(); // the list of attacks should appear
                            break;

                        case "4": // Show status
                            ShowStatus(player, enemy);
                            break;

                        case "5":
                            Console.WriteLine($"{player.Name} surrenders!");
                            player.CurrentHealth = 0;
                            playerEndedTurn = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice — try again.");
                            break;
                    }
                }
                if (enemy.CurrentHealth <= 0)
                {
                    Console.WriteLine($"\n{enemy.Name} has been defeated! {player.Name} wins!");
                    break;
                }

                // Small delay to seperate announcements (optional cen be deleted)
                System.Threading.Thread.Sleep(400);

                // ========== Enemy turn ==========
                Console.WriteLine($"\n--- {enemy.Name}'s turn ---");
                enemy.Attack(player);

                // check if player is dead after enemy attack
                if (player.CurrentHealth <= 0)
                {
                    Console.WriteLine($"\n{player.Name} has been defeated! {enemy.Name} wins!");
                    break;
                }

            }

            static void ShowStatus(Character a, Character b)
            {
                Console.WriteLine($"\nStatus:");
                Console.WriteLine($"{a.Name}: {a.CurrentHealth}/{a.MaxHealth} HP");
                Console.WriteLine($"{b.Name}: {b.CurrentHealth}/{b.MaxHealth} HP");
            }
        }
    }
}
