using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static BattleArena.Warriors.Marksman;


namespace BattleArena
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var Medillo = new Tank("Medillo", 300, 15, 5);
            var Orbeast = new Marksman("Orbeast", 150, 32, 10 );
            var Dedong = new Fighter("Dedong", 200, 20, 7);

            Medillo.DisplayStatus();
            Orbeast.DisplayStatus();
            Dedong.DisplayStatus();

            while (Medillo.IsAlive && Orbeast.IsAlive)
            {
                Console.WriteLine("\n\n====================================");
                Medillo.Attack(Orbeast);
                Thread.Sleep(1000);
                Orbeast.Attack(Medillo);
                Thread.Sleep(1000);
                Console.WriteLine("------------------------------------");

            }

            Console.ReadKey();
        }
    }
}