using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors.Characters
{
    public class RafaelaTete : Warrior, IHealCaster
    {
        public int HealingForEveryone { get; set; }
        public RafaelaTete(int health, int attackPower, int speed, int healingForEveryone, TeamType teamType)
            : base("RafaelaTete", health, attackPower, speed, WarriorType.Magery, teamType)
        {
            HealingForEveryone = healingForEveryone;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "heal", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Lasapin mo yung heal ko {target.Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Asar lul {Name}");
        }

        public void HealTeamMates(List<Warrior> teamMates)
        {
            foreach (var warrior in teamMates)
            {
                if (warrior.IsAlive && warrior.TeamType == TeamType)
                {
                    Console.WriteLine($"->{Name}: Hala, Heal ko na lang si {warrior.Name}!");
                    warrior.ReceiveHealing(HealingForEveryone, this);
                }
                else
                    Console.WriteLine($"->{Name}: Sayang, patay na si {warrior.Name}. " +
                        $"Hindi ko na siya maheal.");
            }
        }
    }
}