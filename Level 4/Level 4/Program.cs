using System;

namespace Level_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code would be more clear if the variables were named based on what they are storing.

            Console.WriteLine("What kind of thing are we talking about?");
            string a = Console.ReadLine(); // This is the item.
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine(); // This is an adjective for the item.
            string c = "Doom"; // This describes the items effect.
            string d = "3000"; // This is the power level of the item.
            Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
        }
    }
}
