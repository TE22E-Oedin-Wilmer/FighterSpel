// SLUMP
// Random generator = new Random();

// int slumptal = generator.Next(10, 20);

// int randomtal = generator.Next(10, 20);



// Console.WriteLine(slumptal);


// WHILE-LOOP

int VaderHP = 100;
int LukeHP = 100;

while (VaderHP > 0 && LukeHP > 0)
{

    Random generator = new Random();

    int damageVader = generator.Next(0, 15);

    int damageLuke = generator.Next(0, 15);

    Console.WriteLine($"Vader HP: {VaderHP}");
    Console.WriteLine($"Luke HP: {LukeHP}");
    Console.WriteLine("Keep dueling! Press [ENTER]");
    
    VaderHP -= damageVader;
    LukeHP -= damageLuke;
    Console.ReadKey();
}

if (LukeHP < VaderHP)
{
    Console.WriteLine("Vader showed his true powers and won!");
}

else if (VaderHP < LukeHP)
{
    Console.WriteLine("Luke was to fast for his old man and won!");
}




// Console.WriteLine("FÄRDIG");


Console.ReadLine();