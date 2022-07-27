using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

 namespace Raiding
{
    internal class Engine : IEngine
    {
        private readonly IWriter writer;
        private readonly IReader reader;

        public Engine(IWriter writer, IReader reader)
        {
            this.writer = writer;
            this.reader = reader;
        }

        public void Run()
        {
                 List<BaseHero> raid = new List<BaseHero>();
            int numberOfHeroes=int.Parse(reader.ReadLine());
            
            for(int i = 0; i < numberOfHeroes; i++)
            {
                string heroName=reader.ReadLine();
                string heroType=reader.ReadLine();

                if(heroType == "Druid")
                {
                    BaseHero newHero = new Druid(heroName);
                    raid.Add(newHero);
                }
                else if (heroType == "Paladin")
                {
                    BaseHero newHero = new Paladin(heroName);
                    raid.Add(newHero);
                }
                else if (heroType == "Rogue")
                {
                    BaseHero newHero = new Rogue(heroName);
                    raid.Add(newHero);
                }
                else if (heroType == "Warrior")
                {
                    BaseHero newHero = new Warrior(heroName);
                    raid.Add(newHero);
                }
                else
                {
                    writer.WriteLine("Invalid hero!");
                }
            }

            int bossHealth = int.Parse(reader.ReadLine());

            int raidPower = 0;

            if (raid.Count > 0)
            {
                foreach (var hero in raid)
                {
                    writer.WriteLine(hero.CastAbility());
                    raidPower += hero.Power;
                }
            }

            if (bossHealth <= raidPower)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }
    }
}
