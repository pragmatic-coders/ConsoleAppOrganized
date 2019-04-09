using System;
namespace Models.Pets
{
    public class Cat : IPet
    {
        public string TalkToOwner()
        {
            return "Meow!";
        }
    }
}