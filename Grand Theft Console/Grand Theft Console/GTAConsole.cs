using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAConsole
{
    class Voertuig
    {
        private ConsoleColor kleur;

        public Voertuig(ConsoleColor kleur)
        {
            this.kleur = kleur;
        }

        public virtual void Rij()
        {
            Console2.WriteLine("Het {{voertuig}} rijdt...", ConsoleColor.White, kleur);
        }

        public virtual void Stuur(int graden)
        {
            Console.WriteLine("");
        }

        public virtual void LaadLeeg()
        {
            Console2.WriteLine("Het {{voertuig}}...", ConsoleColor.White, kleur);
        }
    }

    class Auto : Voertuig
    {
        public Auto() : base(ConsoleColor.DarkYellow)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De auto rijdt...", ConsoleColor.Red);
        }
    }

    class Vrachtwagen : Voertuig
    {
        public Vrachtwagen()
            : base(ConsoleColor.Green)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De vrachtwagen rijdt...", ConsoleColor.Red);
        }

        public override void Stuur(int graden)
        {
            Console.WriteLine("De vrachtwagenchauffeur kijkt in zijn dode-hoek-spiegel");
            base.Stuur(graden);
        }

        public override void LaadLeeg()
        {
        }
    }

    class FighterJet : Voertuig
    {
        public FighterJet()
            : base(ConsoleColor.Gray)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De FighterJet vliegt en schiet racketten...", ConsoleColor.Blue);
        }

        public override void Stuur(int graden)
        {
            Console.WriteLine("De FighterJet vraagt of hij mag landen...");
            base.Stuur(graden);
        }
        public override void LaadLeeg()
        {
            Console2.WriteLine("De FighterJet Dropt Bommen in een bepaald land ;)", ConsoleColor.Green);
        }
    }
}