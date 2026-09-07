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
            Warrior Kupal = new Warrior();
            Kupal.Name = "KupalsiAgoot";
            Kupal.Health = 300;
            Kupal.AttackPower = 50;

            Warrior Orbading = new Warrior();
            Orbading.Name = "Orbading";
            Orbading.Health = 10;
            Orbading.AttackPower = 1;

            Warrior Dedong = new Warrior();
            Dedong.Name = "Dedong";
            Dedong.Health = 100;
            Dedong.AttackPower = 20;


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