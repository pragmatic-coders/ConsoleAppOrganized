using System;
namespace Models.Pets
{
    public class Dog : IPet
    {
        public string TalkToOwner()
        {
            return "Woof!";
        }
    }
}