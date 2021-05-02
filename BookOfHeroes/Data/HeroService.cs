using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookOfHeroes.Data
{
    public class HeroService
    {
        private readonly MessageService messageService;

        public HeroService(MessageService messageService)
        {
            this.messageService = messageService;
        }

        private static readonly Hero[] heroes = new Hero[]
        {
            new Hero() { Id = 11, Name = "Jaina Proudmoore" },
            new Hero() { Id = 12, Name = "Rexxar" },
            new Hero() { Id = 13, Name = "Garrosh Hellscream" },
            new Hero() { Id = 14, Name = "Uther Lightbringer" },
            new Hero() { Id = 15, Name = "Anduin Wrynn" },
            new Hero() { Id = 16, Name = "Valeera Sanguinar" },
            new Hero() { Id = 17, Name = "Thrall" },
            new Hero() { Id = 18, Name = "Gul'dan" },
            new Hero() { Id = 19, Name = "Malfurion Stormrage" },
            new Hero() { Id = 20, Name = "Illidan Stormrage" },
        };

        public Task<Hero[]> GetHeroesAsync()
        {
            messageService.Add("HeroService: fetched heroes");
            return Task.FromResult(heroes);
        }
    }
}