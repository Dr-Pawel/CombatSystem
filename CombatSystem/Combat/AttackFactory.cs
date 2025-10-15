using CombatSystem.Combat.Effetcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSystem.Combat
{
    internal class AttackFactory
    {
        public static Attack CreateFireball()
        {
            return new MagicAttack("Fireball", 30, new BurnEffect());
        }
        public static Attack CreateLightningStrike()
        {
            return new MagicAttack("Lightining Strike", 30, new LightningEffect());
        }

        public static Attack CreateBite()
        {
            return new PhysicalAttack("Bite", 20);
        }

        public static Attack CreateBloodDrain()
        {
            return new MagicAttack("Blood Drain", 30, new BleedingEffect());
        }

        public static Attack CreateSwordSlash()
        {
            return new PhysicalAttack("Sword Slash", 50);
        }
    }
}
