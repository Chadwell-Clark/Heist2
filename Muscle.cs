using System;

namespace HeistII
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is muscling the security guards. The Security points have decreased {SkillLevel} points");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has overwhelmed the Bank Security Guards.");
            }

        }
    }
}