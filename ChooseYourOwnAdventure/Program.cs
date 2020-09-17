using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.WriteLine("Type YES or NO:");
            string noiseChoice = Console.ReadLine().ToUpper();

            if (noiseChoice == "NO")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
            } 
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it.Do you open it or knock ? ");
                Console.WriteLine("type OPEN or KNOCK:");
                string doorchoice = Console.ReadLine().ToUpper();

                if (doorchoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \" \n \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    Console.WriteLine("Type Your answer:");
                    string riddleAnswer = Console.ReadLine().ToUpper();

                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there. \n You keep walking down the hall and hear a noise in your kitchen. Do you go take a look or go back to bed.");
                        Console.WriteLine("Type KITCHEN or BED.");
                        string kitchbed = Console.ReadLine().ToUpper();

                        if (kitchbed == "KITCHEN")
                        {
                            Random rnd = new Random();
                            int random = rnd.Next(1, 4);
                            switch (random)
                            {
                                case 1:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You go downstairs and into the kitchen and see someone in your house. They fall and pass out. You call the cops and they arrest them. \n THE END");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("You trip and fall. This scares whoever was in your houseand they get away. \n THE END");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("You wake up in a cold sweat. But it was just a dream \n THE END");
                                        break;
                                    }
                            }
                           
                        }
                        else if (kitchbed == "BED")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You run back up and hide in your bed until you fall asleep. \nTHE END");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END.");
                    }
                }
                else if (doorchoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("Enter a number (1-3):");
                    int keyChoice = Convert.ToInt32(Console.ReadLine());

                    switch (keyChoice)
                    {
                        case 1:
                            {
                                Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Do you keep going forwards or go backwards?");
                                Console.WriteLine("type FORWARD or BACKWARD");
                                string forBack = Console.ReadLine().ToUpper();
                                if (forBack == "FORWARD")
                                {
                                    Console.WriteLine("You go forward and hear another noise downstairs. \n do you go and look downstairs for the noise or sneak out of the house?");
                                    Console.WriteLine("type DOWNSTAIRS or SNEAK");
                                    string downsneak = Console.ReadLine().ToUpper();
                                    if (downsneak == "DOWNSTAIRS")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You go downstairs and look into the kitchen where you heard the noise. \nYou peak around the corner and a pan crashes *BANG* as a racoon scurries out the door. \n THE END");
                                    }
                                    else if (downsneak == "SNEAK")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("You sneak past whatever was making noises and walk out the door and run away \n THE END");
                                    }
                                }
                                else if (forBack == "BACKWARD")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You go back into your room and go to bed \n THE END");
                                }
                                break;
                            }
                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
                                break;
                            }
                        case 3:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You choose the third key. The door doesn't open.\nTHE END.");
                                break;
                            }
                    }
                }
            }
            
        }
    }
}
