﻿// SLUMP
// Random generator = new Random();

// int slumptal = generator.Next(10, 20);

// int randomtal = generator.Next(10, 20);



// Console.WriteLine(slumptal);


// WHILE-LOOP

int VaderHP = 100;
int LukeHP = 100;

Console.WriteLine("Two fighters appear and a feral battle to the death is about to begin.");
Console.WriteLine("Luke steps forward.");
Console.WriteLine("Vader emerges from the dark.");
Console.WriteLine();
Console.WriteLine("Current HP:");
Console.WriteLine($"Vader: {VaderHP}");
Console.WriteLine($"Luke: {LukeHP}");
Console.WriteLine("Start duel! Press [ENTER]");
Console.WriteLine();

// VaderHP -= damageVader;
// LukeHP -= damageLuke;
Console.ReadKey();
Random generator = new Random();

while (VaderHP > 0 && LukeHP > 0)
{

    int damageVader = generator.Next(0, 15);

    int damageLuke = generator.Next(0, 15);

    VaderHP -= damageVader;
    LukeHP -= damageLuke;

    Console.Clear();
    Console.WriteLine($"Vader took {damageVader} damage!");
    Console.WriteLine($"Luke took {damageLuke} damage!");
    Console.WriteLine();
    Console.WriteLine("Current HP:");
    Console.WriteLine($"Vader: {VaderHP}");
    Console.WriteLine($"Luke: {LukeHP}");
    Console.WriteLine();    
    Console.WriteLine("Keep dueling! Press [ENTER]");
    Console.WriteLine();

    
    Console.ReadKey();
}

if (LukeHP < VaderHP)
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Vader showed his true powers and won!");
    VaderWon();
}

else if (VaderHP < LukeHP)
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Luke was to fast for his old man and won!");
    LukeWon();
}

else if (VaderHP == LukeHP)
{
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("An equal duel. Balance in the force was achieved.");
    
}



// Console.WriteLine("FÄRDIG");

static void VaderWon()
{
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("                                    7732546998800000088996452377                                    ");
Console.WriteLine("                               73569000000000000000000000000000096537                               ");
Console.WriteLine("                           7368000000000864522320000232254690000000008637                           ");
Console.WriteLine("                        759000000095317        1000017       7135900000009577                       ");
Console.WriteLine("                     7590000006217     71246999800008999642177    7126000000957                     ");
Console.WriteLine("                  736000008517         10000000000000000000037        715800000637                  ");
Console.WriteLine("                73800000417            74000000000000000000617           71400000827                ");
Console.WriteLine("               300000917         7729000000000000000000000000008517         719000002               ");
Console.WriteLine("             380000617        7280000000000000000000000000000000000827        716000003             ");
Console.WriteLine("           76000097        7200000000000000000000000000000000000000000027        76000067           ");
Console.WriteLine("         73800001       71600000000000000000009666666900000000000000000009177      18000827         ");
Console.WriteLine("        7500005  71437718000000000000000000000        00000000000000000000081773417  5000047        ");
Console.WriteLine("       7900081  7500098000000000000000000000001      70000000000000000000000009000577 1800097       ");
Console.WriteLine("      1000091  79000000000000000000000000000004      40000000000000000000000000000081  1900001      ");
Console.WriteLine("     180000092200000000000000000000000000000000      000000000000000000000000000000002290000001     ");
Console.WriteLine("    1900000000000000000000000000000000000000000      0000000000000000000000000000000000000000081    ");
Console.WriteLine("   160009726000000000000000000000000000000000007    700000000000000000000000000000000000627600091   ");
Console.WriteLine("  7400087 72000000000000825800000000000000000005    50000000000000000000852800000000000057 7900047  ");
Console.WriteLine(" 7300001 7380000000000087  726000000000000000008    900000000000000000927  1800000000000827 7800027 ");
Console.WriteLine(" 7600027 190000000000087      750000000000006521    125400000000000057      780000000000091  200061 ");
Console.WriteLine("7300091 750000000000081         72900000841              15800000927         780000000000057 7900027");
Console.WriteLine("7600027 712580000000009637        7140027                  7300437        736900000000085217 7200067");
Console.WriteLine("100091     19000000000000086377      77                      77       7368000000000000091     190001");
Console.WriteLine("500047    7500000000000000000089577                              7759800000000000000000057    740005");
Console.WriteLine("600057    740000000000000000000000057                          720000000000000000000000047    720006");
Console.WriteLine("90082     16000000000000000000000002                            20000000000000000000000091     38009");
Console.WriteLine("00083     19000000000000000000000067                            74000000000000000000000093     38000");
Console.WriteLine("00083     1900000000000000000000004                              4000000000000000000000083     39000");
Console.WriteLine("00083     19000000000000000000000067                            74000000000000000000000093     38000");
Console.WriteLine("90082     16000000000000000000000002                            20000000000000000000000091     38009");
Console.WriteLine("600057    740000000000000000000000057                          720000000000000000000000067    720006");
Console.WriteLine("500047    750000000000000000008917                                716800000000000000000057    750005");
Console.WriteLine("100091     1900000000000009417       17                      71       7159000000000000093     190001");
Console.WriteLine("7600027 713280000000089477        7190037                  7300937        775980000000082317 7300097");
Console.WriteLine("7300091 750000000000081        775800000851              158000008577        780000000000057 7900027");
Console.WriteLine(" 1600027 190000000000087      140000000000004221    122400000000000041      780000000000091  200091 ");
Console.WriteLine(" 7300081 7380000000000001  728000000000000000008    900000000000000000827  1800000000000827 7800027 ");
Console.WriteLine("  7400097 72000000000000054800000000000000000005    20000000000000000000045800000000000057 7900047  ");
Console.WriteLine("   160009734800000000000000000000000000000000007    700000000000000000000000000000000008637600091   ");
Console.WriteLine("    1900000000000000000000000000000000000000000      0000000000000000000000000000000000000000081    ");
Console.WriteLine("     180000092200000000000000000000000000000000      000000000000000000000000000000002290000001     ");
Console.WriteLine("      1000091  18000000000000000000000000000004      50000000000000000000000000000081  1600001      ");
Console.WriteLine("      7900081  7500098000000000000000000000007      70000000000000000000000009000477 1800097       ");
Console.WriteLine("        7400005  71427738000000000000000000000        00000000000000000000083773437  5000047        ");
Console.WriteLine("         72800081       73900000000000000000008999999800000000000000000009377      18000827         ");
Console.WriteLine("          779000067       772000000000000000000000000000000000000000000577       760000917          ");
Console.WriteLine("             30000061         7200000000000000000000000000000000000027         74000003             ");
Console.WriteLine("               300000917         7758000000000000000000000000008517         779000002               ");
Console.WriteLine("               72800000477            74000000000000000000617           77500000827                ");
Console.WriteLine("                 739000008217         10000000000000000000037        712800000937                  ");
Console.WriteLine("                     7580000006317     71249988800008889942377    7136000000857                     ");
Console.WriteLine("                        748000000095317        1000017       7135900000008477                       ");
Console.WriteLine("                           7268000000000965223320000233225690000000008627                           ");
Console.WriteLine("                               73568000000000000000000000000000086537                               ");
Console.WriteLine("                                    7732469988000000008899642377                                    ");
}

static void LukeWon()
{
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("                                                 117                                                ");
Console.WriteLine("                                               7280477                                              ");
Console.WriteLine("                                              79000083                                              ");
Console.WriteLine("                                            760000000097                                            ");
Console.WriteLine("                                          7280000000000057                                          ");
Console.WriteLine("                       751               1600000000000000937              7437                      ");
Console.WriteLine("                    72867               73900000000000000027               73847                    ");
Console.WriteLine("                  75002                  719000000000000827                  790617                 ");
Console.WriteLine("                7200037             71    7180000000000047    71              7400917               ");
Console.WriteLine("               100083             7500081   5000000000087  7600067             7500097              ");
Console.WriteLine("            77800082           77390000008277800000000077160000000277            50000477           ");
Console.WriteLine("           75000005            74000000000091400000000074000000000091             40000837          ");
Console.WriteLine("         774000004             77480000000000500000000900000000000417             7900000577        ");
Console.WriteLine("        7190000087                 160000000000000000000000000093                  100000067        ");
Console.WriteLine("        180000002                    79000000000000000000000083                     400000097       ");
Console.WriteLine("       100000008                       20000000000000000000067                      7000000087      ");
Console.WriteLine("      1800000002                       7300000000000000000057                        9000000097     ");
Console.WriteLine("     79000000007                        75000000000000000047                         50000000047    ");
Console.WriteLine("    74000000008                          740000000000000083                          20000000082    ");
Console.WriteLine("    38000000008                           28000000000000047                          200000000067   ");
Console.WriteLine("   760000000008                           7600000000000083                           400000000002   ");
Console.WriteLine("   3800000000007                           500000000000097                           8000000000067  ");
Console.WriteLine("  74000000000004                           180000000000067                          10000000000083  ");
Console.WriteLine("  190000000000007                          190000000000067                          900000000000057 ");
Console.WriteLine("  380000000000006                          180000000000067                         4000000000000047 ");
Console.WriteLine(" 72000000000000004                         400000000000067                        50000000000000091 ");
Console.WriteLine(" 720000000000000005                       7600000000000091                       200000000000000081 ");
Console.WriteLine(" 75000000000000000047                     50000000000000047                     2000000000000000081 ");
Console.WriteLine(" 750000000000000000081                   160000000000000005                   740000000000000000081 ");
Console.WriteLine(" 72000000000000000000047               7160000000000000000027               71000000000000000000091 ");
Console.WriteLine("  3000000000000000000000977           730000000000000000000057           77400000000000000000000061 ");
Console.WriteLine("  19000000000000000000000006317  777160000000000000000000000009117    71500000000000000000000000057 ");
Console.WriteLine("  740000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002  ");
Console.WriteLine("  720000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000091  ");
Console.WriteLine("   19000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000057  ");
Console.WriteLine("   7500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000091   ");
Console.WriteLine("    790000000000000000000000000000000000000000000000000000000000000000000000000000000000000000047   ");
Console.WriteLine("     3800000000000000000000000000000000000000000000000000000000000000000000000000000000000000097    ");
Console.WriteLine("      20000000000000000000000000000000000000000000000000000000000000000000000000000000000000003     ");
Console.WriteLine("      7500000000000000000000000000000000000000000000000000000000000000000000000000000000000002      ");
Console.WriteLine("       750000000000000000000000000000000000000000000000000000000000000000000000000000000000057      ");
Console.WriteLine("        7500000000000000000000000000000000000000000000000000000000000000000000000000000000057       ");
Console.WriteLine("         72000000000000000000000000000000000000000000000000000000000000000000000000000000027        ");
Console.WriteLine("          738000000000000000000000000000000000000000000000000000000000000000000000000000827         ");
Console.WriteLine("           7760000000000000000000000000000000000000000000000000000000000000000000000000917          ");
Console.WriteLine("             730000000000000000000000000000000000000000000000000000000000000000000000047            ");
Console.WriteLine("                2000000000000000000000000000000000000000000000000000000000000000000087              ");
Console.WriteLine("                 75000000000000000000000000000000000000000000000000000000000000000817               ");
Console.WriteLine("                   7580000000000000000000000000000000000000000000000000000000000937                 ");
Console.WriteLine("                      1800000000000000000000000000000000000000000000000000000061                    ");
Console.WriteLine("                        72900000000000000000000000000000000000000000000000093                       ");
Console.WriteLine("                           729800000000000000000000000000000000000000008637                         ");
Console.WriteLine("                               7269000000000000000000000000000000089437                             ");
Console.WriteLine("                                   7735698800000000000000008964237                                  ");
Console.WriteLine("                                            77113333311777                                          ");
}

Console.ReadLine();