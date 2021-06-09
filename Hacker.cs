using System;

namespace HeistII
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine($"{Name} is hacking the Alarm System. The Security points have decreased {SkillLevel}");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has deactivated the vault alarm system!");
            }

        }
    }
}