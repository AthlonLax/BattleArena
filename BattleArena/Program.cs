using BattleArena.Enums;
using BattleArena.Warriors.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mga Taong kupal
            var Orbeast = new Orbeast(100, 30, 25, 8, TeamType.A);
            var Agoot = new Agoot(150, 20, 15, 7, TeamType.A);
            var Medillo = new Medillo(100, 10, 15, 6, TeamType.A);
            var Aaron = new Aaron(120, 15, 10, 8, TeamType.A);
            var AdolfoASS = new AdolfoASS(100, 20, 15, 9, TeamType.A);
            // Mga Taong mobile legends
            var Balmond = new Balmond(120, 15, 10, 8, TeamType.B);
            var Hayabutaw = new Hayabutaw(100, 20, 15, 9, TeamType.B);
            var Tigreal = new Tigreal(150, 10, 20, 7, TeamType.B);
            var Roblox = new Roblox(100, 15, 10, 8, TeamType.B);
            var Rafaela = new RafaelaTete(120, 10, 15, 6, TeamType.B);


            BattleArena.AddWarrior(Medillo);
            BattleArena.AddWarrior(Agoot);
            BattleArena.AddWarrior(Orbeast);
            BattleArena.AddWarrior(Aaron);
            BattleArena.AddWarrior(AdolfoASS);

            BattleArena.AddWarrior(Hayabutaw);
            BattleArena.AddWarrior(Balmond);
            BattleArena.AddWarrior(Tigreal);
            BattleArena.AddWarrior(Rafaela);
            BattleArena.AddWarrior(Roblox);


            BattleArena.StartBattle();
        }
    }
}