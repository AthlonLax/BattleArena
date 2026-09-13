using BattleArena.Combat;
using System;
using BattleArena.Enums;
using System.Threading;


namespace BattleArena.Warriors.Characters
{

    public class Aaron : Warrior
    {
        public int PunchDamage { get; private set; }
        public Aaron(int health, int attackPower, int punchDamage, int speed, TeamType teamType)
            : base("Aaron", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            PunchDamage = punchDamage;
            attackPower += punchDamage;
        }

        public Aaron(string name, int health, int attackPower, int speed, TeamType teamType)
            : base(name, health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            PunchDamage = PunchDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Punch", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: Suntok ka saken {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: yeouch!");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{Name}: Kupal!{target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");

        }

    }
}