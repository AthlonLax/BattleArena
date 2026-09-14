using BattleArena.Combat;
using System;
using System.Threading;
using BattleArena.Enums;

namespace BattleArena.Warriors.Characters
{
    public class Hayabutaw : Warrior
    {
        public int CritMultiplier { get; private set; }

        public Hayabutaw(int health, int attackPower, int critMultiplier, int speed, TeamType teamType)
            : base("Hayabutaw", health, attackPower, speed, WarriorType.Assasin, teamType)
        {
            CritMultiplier = critMultiplier;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Backstab", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Silent Strike {target.Name}...");
            Thread.Sleep(1000);

            if (dmginfo.IsCritical)
                Console.WriteLine($"-> Critical! Damage x{CritMultiplier}");
        }
    }
}
