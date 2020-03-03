using System;
using FirstStringBuilder.Entities;

namespace FirstStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip! ");
            Comment c2 = new Comment("Wow that's Awesome! ");
            Post p1 = new Post(DateTime.Parse("21/06/2018"), "Traveling to New Zealand", "I'm going visit this wondefull country!", 12);
            
        }
    }
}
