using CombatSystem.Characters;

namespace CombatSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player hero = new Player("Hero", 100);
            Enemy ghoul = new Enemy("Ghoul", 50);

            hero.Attack(ghoul);
            ghoul.Attack(hero);
        }
    }
}
