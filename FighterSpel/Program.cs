// SLUMP
// Random generator = new Random();

// int slumptal = generator.Next(10, 20);

// int randomtal = generator.Next(10, 20);



// Console.WriteLine(slumptal);


// WHILE-LOOP

using System.Collections.ObjectModel;
using System.Drawing;

int VaderHP = 100;
int LukeHP = 100;

while (VaderHP > 0 && LukeHP > 0)
{


    Random generator = new Random();

    int damageVader = generator.Next(0, 15);

    int damageLuke = generator.Next(0, 15);
    Console.Clear();
    Console.WriteLine($"Vader took {damageVader} damage!");
    Console.WriteLine($"Luke took {damageLuke} damage!");
    Console.WriteLine();
    Console.WriteLine("Current HP:");
    Console.WriteLine($"Vader: {VaderHP}");
    Console.WriteLine($"Luke: {LukeHP}");
    Console.WriteLine("Keep dueling! Press [ENTER]");
    Console.WriteLine();
    
    VaderHP -= damageVader;
    LukeHP -= damageLuke;
    Console.ReadKey();
}

if (LukeHP < VaderHP)
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Vader showed his true powers and won!");

}

else if (VaderHP < LukeHP)
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Luke was to fast for his old man and won!");
}

else if (VaderHP == LukeHP)
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("An equal duel. Balance in the force was achieved.");
}



// Console.WriteLine("FÄRDIG");


Console.ReadLine();