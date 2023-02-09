namespace RPG_Combined_Madness
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Mennu();
        }
        static void Fight(String Name, String EName)
        {
            Random rng = new Random();
            int min = 1;
            int max = 100;
            //Console.WriteLine("Douglas W Moore \n Now I believe it will be a mostly random generated game. Random generated enemies with random.");
            string BName = EName;
            int Rrn = rng.Next(min, max);
            int Ehth = Rrn;
            Rrn = rng.Next(min, max);
            int Edmg = Rrn;
            Rrn = rng.Next(min, max);
            int Phth = Rrn;
            Rrn = rng.Next(min, max);
            int Pdmg = Rrn;
            string EWrd = "Hit'n";
            int OPdmg = Pdmg;
            int OPhth = Phth;
            int OEhth = Ehth;
            if (Name != "" || Name != "Player")
            {
                Console.WriteLine("HELLO! " + Name + " Welcome to \nHere, You will fight the basic Beast using you Moves.\nThe Beast will also use their moves to destroy you.\nThe goal of each is to get their enemies health down to zero, exactly zero.\n");
                Console.WriteLine("There are several differnt moves to use, each does something differnt.\n");
                Console.WriteLine("Please answer if you want the manual.");
                string YeNo = Convert.ToString(Console.ReadLine());
                if (YeNo != "")
                {
                    Console.WriteLine("Mod uses the % with your damage basically making it one or zero." +
                        "\nDiv uses / on your own damage making it less, divided." +
                        "\nTimm makes your Damage times a random number within itself." +
                        "\nTim just does your damage minus a random number." +
                        "\nPlu just is yours with a random number added.");
                }
            }
            Console.WriteLine(BName + "'s Health = E" + Ehth + "\n" + BName + "'s Damage = Ed" + Edmg + "\n" + Name + "'s Health = P" + Phth + "\n" + Name + "'s Damage = Pd" + Pdmg + "\n");
            Console.WriteLine(Name + "'s Health = P" + Phth + "\n" + BName + "'s Health = E" + Ehth);

            while (Ehth > 0 || Phth > 0)
            {
                if (Ehth == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(Name);
                    Console.WriteLine("Name");
                    Console.WriteLine("The nearly Impossible Victory has been achived");
                    Console.WriteLine(BName + " has been defeated.");
                    Thread.Sleep(10000);
                    Console.Clear();
                    Console.WriteLine("Now you must defeat it's other twin, also named " + BName + ".");
                    break;
                }
                if (Phth == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("The nearly Impossible Victory has been achived");
                    Console.WriteLine(Name + " has been defeated.");
                    Console.WriteLine(Name + " has been defeated.");
                    Console.WriteLine(BName + " has defeated " + Name);
                    Thread.Sleep(10000);
                    Console.Clear();
                    Console.WriteLine("Now you have to restart.");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine("Good job loser.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;


                }
                Console.WriteLine("\nMoves:\nMod 2%\nDiv 2/\nTimm ^2*\nTim 1=\nMin -\nPluS +\n");
                string Hurt = Convert.ToString(Console.ReadLine());
                if (Hurt == "")
                {
                    Console.WriteLine("Re " + Name + "WeTo");
                }
                if (Hurt == "Mod")
                {
                    Pdmg = 1;
                }
                if (Hurt == "Div")
                {
                    Rrn = rng.Next(min, OPdmg);
                    Pdmg = OPdmg / OPdmg + Rrn;
                }
                if (Hurt == "Timm")
                {
                    Rrn = rng.Next(min, OPdmg);
                    Pdmg = OPdmg * Rrn;
                }
                if (Hurt == "Tim")
                {
                    Rrn = rng.Next(OPdmg, max);
                    Pdmg = Rrn - OPdmg;
                }
                if (Hurt == "Min")
                {
                    Rrn = rng.Next(min, max);
                    Pdmg = OPdmg - OPdmg + Rrn;
                }
                if (Hurt == "Plu")
                {
                    Rrn = rng.Next(min, OPdmg);
                    Pdmg = OPdmg + Rrn;
                }
                if (Hurt == "AK")
                {
                    Pdmg = Ehth;
                }
                if (Hurt == "ConCon")
                {
                    Pdmg = OPdmg;
                }
                if (Hurt == "End")
                {
                    Pdmg = Ehth - 1;
                }
                Rrn = rng.Next(min, max);
                Edmg = Rrn;
                Ehth = Ehth - Pdmg;
                Phth = Phth - Edmg;
                if (Phth < -1)
                {
                    Phth = OPhth;
                }
                if (Ehth < -1)
                {
                    Ehth = OEhth;
                }
                if (Edmg <= 101 && Edmg >= 81)
                {
                    EWrd = "Claws";
                }
                if (Edmg <= 80 && Edmg >= 51)
                {
                    EWrd = "Fire";
                }
                if (Edmg <= 50 && Edmg >= 41)
                {
                    EWrd = "Axe";
                }
                if (Edmg <= 40 && Edmg >= 19)
                {
                    EWrd = "Punch Of InDesion";
                }
                if (Edmg <= 16 && Edmg >= 18)
                {
                    EWrd = "Maximum Slap";
                    Edmg = Phth;
                }
                if (Edmg <= 15 && Edmg >= 3)
                {
                    EWrd = "Slap";
                }
                if (Edmg <= 2 && Edmg >= 1)
                {
                    EWrd = "Spoon";
                }
                Console.WriteLine(Name + " Used " + Hurt);
                Console.WriteLine(BName + " Used " + EWrd);
                Console.WriteLine("\nP" + Phth + "\nE" + Ehth);
            }
        }
        static void Mennu()
        {
            int nmb = 0;
            int story = 1;
            int setting1 = 45;
            int setting2 = 10;
            int setting3 = 9;
            int on;
            int straw = 0;
            int Tiles = 1;
            string cake;
            string gender;
            string choice;
            string Name = "Player";
            string EName = "Enemy";
            while (story == 1)
            {

                Console.WriteLine("\n>:Start! = 1");
                Console.WriteLine(">:Continue! = 2");
                Console.WriteLine(">:Settings! = 3");
                Console.WriteLine(">:Exit! = 4");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                choice = Console.ReadLine();

                if (straw == 10)
                {
                    Console.WriteLine("YOUHA\nYOU\nYOu\nWHYMUSTYOUANGERMEINTHISWWAU");
                    Console.WriteLine("Apologies, I have not reacted this way before. Usually\nNormally I don't expect people to do this\nWell done b******\nHope you are happy.\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\n>Start!");
                    Console.WriteLine(">Continue!");
                    Console.WriteLine(">Settings!");
                    Console.WriteLine(">Exit!");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    cake = Console.ReadLine();
                    Console.WriteLine("\nExiting...\n");
                    while (nmb <= 100)
                    {
                        Console.WriteLine(nmb);
                        nmb++;
                    }
                    Console.WriteLine("\nDone!");
                    story = 0;
                }
                else if (choice == "1")
                {
                    Console.WriteLine("\nStarting New Game...\n");
                    while (nmb <= 100)
                    {
                        Console.WriteLine(nmb);
                        nmb++;
                    }
                    nmb = 0;
                    Console.WriteLine("\nDone!\n");
                    Console.Clear();
                    if (true)
                    {
                        Console.WriteLine("Choose Gender :\n>:Male! = 1\n>:Female! = 2");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            gender = "Male";
                        }
                        else if (choice == "2")
                        {
                            gender = "Female";
                        }
                        Console.Write("Input Name : ");
                        Name = Convert.ToString(Console.ReadLine());
                        Random rng = new Random();
                        int min = 0;
                        int max = 2;
                        MazeTime(Name, EName, Tiles);


                    }
                }
                else if (choice == "2")
                {
                    MazeTime(Name, EName, Tiles);
                }
                else if (choice == "3")
                {
                    on = 1;
                    while (on == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("\nSettings\n");
                        Console.WriteLine(">:Draw Speed! = 1\n>:" + setting1);
                        Console.WriteLine(">:Strength! = 2\n>:" + setting2);
                        Console.WriteLine(">:Rn! = 3\n>:" + setting3);
                        Console.WriteLine(">:Eneme! = 4\n>:" + EName);
                        Console.WriteLine(">:Tiles! = 5\n>:" + Tiles);
                        Console.WriteLine(">:Exit! = 6\n");
                        string setch = Console.ReadLine();
                        if (setch == "3")
                        {
                            Console.WriteLine("Set To : ");
                            int set = Convert.ToInt32(Console.ReadLine());
                            setting3 = set;
                        }
                        else if (setch == "2")
                        {
                            Console.WriteLine("Set To : ");
                            int set = Convert.ToInt32(Console.ReadLine());
                            setting2 = set;
                        }
                        else if (setch == "1")
                        {
                            Console.WriteLine("Set To : ");
                            int set = Convert.ToInt32(Console.ReadLine());
                            setting1 = set;
                        }
                        else if (setch == "4")
                        {
                            Console.WriteLine("Set To : ");
                            string set = Convert.ToString(Console.ReadLine());
                            EName = set;
                        }
                        else if (setch == "5")
                        {
                            Console.WriteLine("Set To : ");
                            int numset = Convert.ToInt32(Console.ReadLine());
                            Tiles = numset;
                        }
                        else if (setch == "6")
                        {
                            on = 0;
                        }
                    }
                    Console.Clear();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("\nExiting...\n");
                    cake = Console.ReadLine();
                    while (nmb <= 100)
                    {
                        Console.WriteLine(nmb);
                        nmb++;
                    }
                    Console.WriteLine("\nDone!");
                    story = 0;
                }
                else if (choice == "")
                {
                    Console.WriteLine("Please Input");
                    straw++;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("SHush MORAA\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.Clear();
                }
            }
        }
        static void MazeTime(String Name, String EName, int Tiles)
        {
            //The room you start in.
            int x = 1;
            int y = 1;
            int z = 1;
            //Warning, Can Break .EXE


            ConsoleKeyInfo ans;
            Random rng = new Random();
            int min1 = 0;
            int max1 = 2;
            int min2 = 0;
            int max2 = 2;
            int min3 = 0;
            int max3 = 2;
            int min4 = 0;
            int max4 = 2;
            int min5 = 0;
            int max5 = 2;
            int min6 = 0;
            int max6 = 2;
            int rn;
            int up;
            int down;
            int left;
            int right;
            int numbers;
            int ascend;
            int decend;
            int tiles = 1;
            int room;
            bool asking;
            int roofh = 4;

            ans = Console.ReadKey();

            while (true)
            {
                numbers = 10;
                up = 0;
                down = 0;
                left = 0;
                right = 0;
                decend = 0;
                ascend = 0;

                //Enemy Generation V ///////////////////////

                rn = rng.Next(0, 10);
                if (rn == 1)
                {
                    Console.Clear();
                    Fight(Name, EName);
                }

                //Room Generation V ///////////////////////



                //Wall Generation V ///////////////////////

                Console.Clear();
                room = x * y * z + y * x * z + z * x * y;
                Console.WriteLine("room = " + room);
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
                rn = rng.Next(min1, max1);
                if (ans.Key == ConsoleKey.S || rn == 0)
                {
                    up = 1;
                    roofh--;
                }
                rn = rng.Next(min2, max2);
                if (ans.Key == ConsoleKey.D || rn == 0)
                {
                    left = 1;
                    roofh--;
                }
                rn = rng.Next(min3, max3);
                if (ans.Key == ConsoleKey.A || rn == 0)
                {
                    right = 1;
                    roofh--;
                }
                rn = rng.Next(min4, max4);
                if (ans.Key == ConsoleKey.W || rn == 0)
                {
                    down = 1;
                    roofh--;
                }
                rn = rng.Next(min5, max5);
                if (ans.Key == ConsoleKey.E || rn == 0)
                {
                    decend = 1;
                }
                if (roofh >= 1)
                {
                    ascend = 1;
                }
                roofh = 4;

                //Movement Inquiry V ///////////

                if (decend == 1)
                {
                    Console.WriteLine(":decend? = q");
                    numbers--;
                }
                if (ascend == 1)
                {
                    Console.WriteLine(":ascend? = e");
                    numbers--;
                }
                if (up == 1)
                {
                    Console.WriteLine(":up? = w");
                    numbers--;
                }
                if (down == 1)
                {
                    Console.WriteLine(":down? = s");
                    numbers--;
                }
                if (left == 1)
                {
                    Console.WriteLine(":left? = a");
                    numbers--;
                }
                if (right == 1)
                {
                    Console.WriteLine(":right? = d");
                    numbers--;
                }
                Console.WriteLine(":exit? = m");
                while (numbers > 0)
                {
                    Console.WriteLine(" ");
                    numbers--;
                }
                Console.WriteLine(@"///////////////////////////////////////////////////////////////////////////////////////////////////////////");

                //Storage V /////////////////////

                int xtimes = 10 ^ x * 3;
                int ytimes = 10 ^ y * 2;
                int ztimes = 10 ^ z * 1;
                int timen = x * xtimes + y * ytimes + z * ztimes
                    ;
                Storage(timen);
                static void Storage(int timen)
                {
                    Console.WriteLine(timen);
                }

                //Textures V ///////////////////

                if (tiles == 1)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"         \________________________/");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"         \                        /");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"         /________________________\");

                    }
                    else
                    {
                        Console.WriteLine(@"         /                        \");

                    }
                }
                if (tiles == 2)
                {
                    //0;
                    if (up == 0)
                    {
                        //12
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"         /oooooooooooooooooooooooo\");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"         /                        \");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                        Console.WriteLine(@"                                    ");
                    }
                    else if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                        Console.WriteLine(@"--------O                          ");
                    }
                    else if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                        Console.WriteLine(@"                                   O---------");
                    }
                    else if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                        Console.WriteLine(@"--------O                          O---------");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"         \oooooooooooooooooooooooo/");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");
                        Console.WriteLine(@"          |||||||||||||||||||||||| ");

                    }
                    else
                    {
                        Console.WriteLine(@"         \                        /");

                    }

                }
                if (tiles == 3)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"        _]________________________[_");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"        _]                        [_");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |/                         ");
                        Console.WriteLine(@"         /                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                        Console.WriteLine(@"         |                         ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                        Console.WriteLine(@"                                  |");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                        Console.WriteLine(@"         |                        |");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"        _]________________________[_");

                    }
                    else
                    {
                        Console.WriteLine(@"        _]                        [_");

                    }
                }
                if (tiles == 4)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _]|=|++t            [___");
                        Console.WriteLine(@"          [____][____]{}{}{}[____]");
                        Console.WriteLine(@"          ____][____]      [____][");
                        Console.WriteLine(@"          ]|||||]            [____");
                        Console.WriteLine(@"          ____][____]      [____][");
                        Console.WriteLine(@"          ___](****)[____][____][_");
                        Console.WriteLine(@"          [____]      [____][&e&2]");
                        Console.WriteLine(@"          _][____]            [___");
                        Console.WriteLine(@"          ____][_\ _]()00()[____][");
                        Console.WriteLine(@"          _][____][__\     c/[____");
                        Console.WriteLine(@"          [____][____]\    /[____]");
                        Console.WriteLine(@"        /\/\/--\^\__/\/\/\//\__/\ /\");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"                                    ");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"     \__                           ");
                        Console.WriteLine(@"        ]                          ");
                        Console.WriteLine(@"       [_,                         ");
                        Console.WriteLine(@"       o |                         ");
                        Console.WriteLine(@"       __p                         ");
                        Console.WriteLine(@"      |     /                      ");
                        Console.WriteLine(@"    n |__, /o                      ");
                        Console.WriteLine(@"    U    |/                        ");
                        Console.WriteLine(@"       _-'                         ");
                        Console.WriteLine(@"     _|                            ");
                        Console.WriteLine(@"    /                              ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                  | ");
                        Console.WriteLine(@"                               v\ \ ");
                        Console.WriteLine(@"                                 \\|");
                        Console.WriteLine(@"                                 _\|");
                        Console.WriteLine(@"                                [   ");
                        Console.WriteLine(@"                               /IIII");
                        Console.WriteLine(@"                              [___  ");
                        Console.WriteLine(@"                                 \  ");
                        Console.WriteLine(@"                                 |_ ");
                        Console.WriteLine(@"                                  ] ");
                        Console.WriteLine(@"                                  \ ");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"     ---|                        /  ");
                        Console.WriteLine(@"      u /                       [_? ");
                        Console.WriteLine(@"       /                         \  ");
                        Console.WriteLine(@"       \                       ___] ");
                        Console.WriteLine(@"    [  _\                      | j  ");
                        Console.WriteLine(@"     ] |                        \ J ");
                        Console.WriteLine(@"    [  |                         \__");
                        Console.WriteLine(@"     ] |                           [");
                        Console.WriteLine(@"    [  _=-'                       [o");
                        Console.WriteLine(@"     ]|                          [__");
                        Console.WriteLine(@"    [ |                           |_");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"        [____][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ][____][____][____][____");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ___][____][____][____][_");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");

                    }
                    else
                    {
                        Console.WriteLine(@"                                    ");

                    }
                }
                if (tiles == 5)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"        ");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"                                    ");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                        Console.WriteLine(@"                                 ");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                            ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                        Console.WriteLine(@"                              ");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"        ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");
                        Console.WriteLine(@"          ");

                    }
                    else
                    {
                        Console.WriteLine(@"                                    ");

                    }
                }
                if (tiles == 6)
                {
                    //0;
                    if (up == 0)
                    {
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ][____][____][____][____");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ___][____][____][____][_");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"        [____][____][____][____][___");
                    }
                    else
                    {
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"");
                        Console.WriteLine(@"                                    ");
                    }
                    if (left == 1 && right == 1)
                    {
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                        Console.WriteLine(@"                                   ");
                    }
                    if (left == 0 && right == 1)
                    {
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     ___]                           ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                        Console.WriteLine(@"     __]                            ");
                    }
                    if (left == 1 && right == 0)
                    {
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                [___");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                        Console.WriteLine(@"                                 [__");
                    }
                    if (left == 0 && right == 0)
                    {
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    ___]                        [___");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                        Console.WriteLine(@"    __]                          [__");
                    }
                    if (down == 0)
                    {
                        Console.WriteLine(@"        [____][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ][____][____][____][____");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          ___][____][____][____][_");
                        Console.WriteLine(@"          [____][____][____][____]");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          ____][____][____][____][");
                        Console.WriteLine(@"          _][____][____][____][___");
                        Console.WriteLine(@"          [____][____][____][____]");

                    }
                    else
                    {
                        Console.WriteLine(@"                                    ");

                    }
                }

                //Movement V///////////////////

                asking = true;
                while (asking == true)
                {
                    ans = Console.ReadKey();
                    if (ans.Key == ConsoleKey.W && up == 1)
                    {
                        y++;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.S && down == 1)
                    {
                        y--;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.A && left == 1)
                    {
                        x--;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.D && right == 1)
                    {
                        x++;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.E && ascend == 1)
                    {
                        z++;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.Q && decend == 1)
                    {
                        z--;
                        asking = false;
                    }
                    if (ans.Key == ConsoleKey.M)
                    {
                        Console.Clear();
                        return;
                    }
                }
            }
        }
    }
}
