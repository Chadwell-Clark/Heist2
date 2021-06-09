using System;
using System.Collections.Generic;

namespace HeistII
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker Solo = new Hacker()
            {
                Name = "Gary McKinnon",
                SkillLevel = 50,
                PercentageCut = 40
            };

            Hacker cOmrade = new Hacker()
            {
                Name = "Jonathan James",
                SkillLevel = 50,
                PercentageCut = 35
            };

            LockSpecialist GentleJohnny = new LockSpecialist()
            {
                Name = "Johnny Ramensky",
                SkillLevel = 40,
                PercentageCut = 35
            };

            LockSpecialist Sitar = new LockSpecialist()
            {
                Name = "Jeff Sitar",
                SkillLevel = 43,
                PercentageCut = 30
            };

            Muscle Jesse = new Muscle()
            {
                Name = "Jessie James",
                SkillLevel = 60,
                PercentageCut = 30
            };

            Muscle Cole = new Muscle()
            {
                Name = "Cole Younger",
                SkillLevel = 50,
                PercentageCut = 25
            };


            List<IRobber> rolodex = new List<IRobber>()
            {
                Solo, cOmrade, GentleJohnny, Sitar, Jesse, Cole
            };
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Its time for a bank Heist!! ");
            Console.WriteLine();
            Console.WriteLine("Lets see how may accomplices we have in the ole Bank Heist Rolodex");
            Console.WriteLine();
            Console.WriteLine($"Looks like we have {rolodex.Count} possible liberators of other peoples money");
            Console.WriteLine();
            Console.Write("Enter a name to add to our collection of honor bound vagabonds... ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine($@"What Specialty does {name} have?

                 Choose 1, 2 or 3...

            1 - Hacker (Disables alarms)
            2 - Muscle (Disarms Guards)
            3 - Lock Specialist (Safe Cracker)
            ... ");
            int specialty = int.Parse(Console.ReadLine());



        }
    }
}
