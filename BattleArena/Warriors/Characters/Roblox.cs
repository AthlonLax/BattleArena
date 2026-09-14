using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Roblox : Warrior
    {
        public int SwordSlash { get; private set; }
        public Roblox(int health, int attackPower, int swordSlash, int speed, TeamType teamType)
            : base("Roblox", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            SwordSlash = swordSlash;
            attackPower += swordSlash;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Slash", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Hihiwain kita {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: aray kopo");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: asa ka boi {target.Name}");
        }
    }

}



