using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Warrior Kupal = new Warrior("KupalAgoot", 300, 50);
            Warrior Orbading = new Warrior("Orbading", 10, 51);

            Warrior Dedong = new Warrior("Dedong", 100, 20);

            Console.WriteLine($"{Kupal.Name} has " +
                $"{Kupal.Health} health and {Kupal.AttackPower} attack power.");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine($"{Orbading.Name} has " +
                $"{Orbading.Health} health and {Orbading.AttackPower} attack power.");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine($"{Dedong.Name} has " +
                $"{Dedong.Health} health and {Dedong.AttackPower} attack power.");
            Console.WriteLine("----------------------------------------------");

            Console.ReadLine();
        }

    }
}