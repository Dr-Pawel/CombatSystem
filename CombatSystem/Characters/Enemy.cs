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
        MagicAttack BloodSpit = new MagicAttack("Blood Spit", 10);
        public Enemy(string name, int maxHealth)
        {
            this.Name = name;
            SetMaxHealth(maxHealth);
            Console.WriteLine($"new Enemy of name {name} has been created. \n");
        }

        public void Attack(IDamageable target, int damage)
        {
            BloodSpit.ExecuteAttack(target);
        }
    }
}
