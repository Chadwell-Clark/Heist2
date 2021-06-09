using System;
using System.Linq;
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

            Bank bank = new Bank()
            {
                AlarmScore = new Random().Next(0, 100),
                VaultScore = new Random().Next(0, 100),
                SecurityGuardScore = new Random().Next(0, 100),
                CashOnHand = new Random().Next(50000, 1000000)
            };

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Its time for a bank Heist!! ");
            Console.WriteLine();
            Console.WriteLine("Lets see how may accomplices we have in the ole Bank Heist Rolodex");
            Console.WriteLine();
            Console.WriteLine($"Looks like we have {rolodex.Count} possible liberators of other peoples money");
            NewCrew();

            ReconReport(bank);

            RolodexList();

            List<IRobber> crew = new List<IRobber>();



            void HeistCrew()
            {
                Console.WriteLine("Enter the Rolodex Number of the New Heist Crew Member : ");
                int rolodexCrewNum = int.Parse(Console.ReadLine()) - 1;

                crew.Add(rolodex[rolodexCrewNum]);

            }
            void RolodexList()
            {
                Console.WriteLine("Rolodex Report");
                int count = 0;
                foreach (IRobber entry in rolodex)
                {
                    count++;
                    Console.WriteLine();
                    Console.WriteLine($"Rolodex # {count}");
                    Console.WriteLine($"Name:  {entry.Name}");
                    Console.WriteLine($"Specialty: {entry.GetType().Name}");
                    Console.WriteLine($"Skill Level: {entry.SkillLevel}");
                    Console.WriteLine($"Cut Demand: {entry.PercentageCut}");

                    Console.WriteLine();
                }
            }




            void ReconReport(Bank bank)
            {
                List<int> bankRecon = new List<int>()
                { bank.AlarmScore, bank.VaultScore, bank.SecurityGuardScore};
                string mostSecure = "";
                string leastSecure = "";


                if (bank.AlarmScore > bank.VaultScore && bank.AlarmScore > bank.SecurityGuardScore)
                {
                    mostSecure = "Alarm";
                }
                else if (bank.VaultScore > bank.AlarmScore && bank.VaultScore > bank.SecurityGuardScore)
                {
                    mostSecure = "Vault";
                }
                else
                {
                    mostSecure = "Security";
                }
                if (bank.AlarmScore < bank.VaultScore && bank.AlarmScore < bank.SecurityGuardScore)
                {
                    leastSecure = "Alarm";
                }
                else if (bank.VaultScore < bank.AlarmScore && bank.VaultScore < bank.SecurityGuardScore)
                {
                    leastSecure = "Vault";
                }
                else
                {
                    leastSecure = "Security";
                }
                Console.WriteLine();
                Console.WriteLine("-*-  Recon Report  -*-");
                Console.WriteLine();
                Console.WriteLine($"Most Secure: {mostSecure} ");
                Console.WriteLine($"Least Secure: {leastSecure} ");
                Console.WriteLine();
                Console.WriteLine("-*-End Recon Report-*-");
                Console.WriteLine();

            }

            void NewCrew()
            {
                Console.WriteLine();
                Console.Write("Enter a name to add to our collection of honor bound vagabonds... ");
                string name = Console.ReadLine();

                if (name == "")
                {
                    Console.WriteLine($"We will pick a crew from the {rolodex.Count} in the Heist Rolodex!");
                    // goto RolodexFilled;

                }
                else
                {

                    Console.WriteLine($@"What Specialty does {name} have?

                 Choose 1, 2 or 3...

            1 - Hacker (Disables alarms)
            2 - Muscle (Disarms Guards)
            3 - Lock Specialist (Safe Cracker)
            ... ");
                    int specialty = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write($"Enter {name}'s SkillLevel (between 1 and 100) :");
                    int skillLevel = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.Write($"What Percentage of the cut does {name} want? (between 1 and 100 percent) :");
                    int cutOfLoot = int.Parse(Console.ReadLine());

                    if (specialty == 1)
                    {

                        Hacker hacker = new Hacker()
                        {
                            Name = name,
                            SkillLevel = skillLevel,
                            PercentageCut = cutOfLoot
                        };
                        rolodex.Add(hacker);

                    }
                    else if (specialty == 2)
                    {
                        Muscle heavy = new Muscle()
                        {
                            Name = name,
                            SkillLevel = skillLevel,
                            PercentageCut = cutOfLoot
                        };
                        rolodex.Add(heavy);
                    }
                    else
                    {
                        LockSpecialist safecracker = new LockSpecialist()
                        {
                            Name = name,
                            SkillLevel = skillLevel,
                            PercentageCut = cutOfLoot
                        };
                        rolodex.Add(safecracker);
                    }

                    NewCrew();
                }
                // RollodexFilled:
                //     Console.WriteLine($"We will pick a crew from the {rolodex.Count} in the Heist Rolodex!");

            }
        }
    }
}
