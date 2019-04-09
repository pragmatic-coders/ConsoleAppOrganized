using System;
using System.Collections.Generic;
using Models.Pets;
using static System.Console;
namespace ConsoleAppOrganized
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPet> pets = new List<IPet>{
                new Dog(),
                new Cat()
            };
            foreach (var pet in pets)
            {
                WriteLine(pet.TalkToOwner());
            }
        }
    }
}
