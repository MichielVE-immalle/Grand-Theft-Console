using GTAConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Theft_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig v = new Voertuig(ConsoleColor.Magenta);
            Voertuig truck = new Vrachtwagen();
            Voertuig F16 = new FighterJet();
            
            F16.Rij();
            F16.LaadLeeg();
        }
    }
}
