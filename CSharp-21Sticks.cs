using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp21Sticks
{
    //A simple game of taking turns to tkae sticks from a pile. The one who takes the last stick will lose.
    class Program
    {
        static void Main(string[] args)
        {
            int Sticks = 21;
            int chosenSticks = 0;

            Console.WriteLine("We will now take turns to choose 1 or 2 sticks at a time. The one who takes the last stick will lose the game.");
            Console.WriteLine("Do you wish to begin?");
            string begin = Console.ReadLine();


            while (Sticks > 0)
            {
                if (begin.ToLower() == "yes")
                {
                    Console.WriteLine("There are currently " + Sticks + " sticks in the pile. Do you take 1 or 2?");
                    chosenSticks = Convert.ToInt32(Console.ReadLine());

                    if (chosenSticks >= 2)
                    {
                        chosenSticks = 2;
                        Console.WriteLine("Okay, 2 sticks it is.");
                    }
                    else if (chosenSticks <= 1)
                    {
                        chosenSticks = 1;
                        Console.WriteLine("So you'll have 1 stick, then.");
                    }

                    Sticks -= chosenSticks;

                    if (Sticks <= 0)
                    {
                        Console.WriteLine("Moahaha, you took the last stick! I win!");
                        Console.ReadKey();
                    }

                    else
                    {
                        if ((Sticks - 2) % 3 == 0 || Sticks - 2 == 0)
                        {
                            chosenSticks = 1;
                        }
                        else
                        {
                            chosenSticks = 2;
                        }

                        Console.WriteLine("I will now take " + chosenSticks + " sticks.");
                        Sticks -= chosenSticks;

                        if (Sticks <= 0)
                        {
                            Console.WriteLine("Congratulations, I took the last stick, therefore you win!");
                            Console.ReadKey();
                        }

                    }
                }

                else
                {
                    if ((Sticks - 2) % 3 == 0 || Sticks - 2 == 0)
                    {
                        chosenSticks = 1;
                    }
                    else
                    {
                        chosenSticks = 2;
                    }
                    Console.WriteLine("I will now take " + chosenSticks + " sticks.");
                    Sticks -= chosenSticks;

                    if (Sticks <= 0)
                    {
                        Console.WriteLine("Congratulations, I took the last stick, therefore you win!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("There are currently " + Sticks + " sticks in the pile. Do you take 1 or 2?");
                        chosenSticks = Convert.ToInt32(Console.ReadLine());

                        if (chosenSticks >= 2)
                        {
                            chosenSticks = 2;
                            Console.WriteLine("Okay, 2 sticks it is.");
                        }
                        else if (chosenSticks <= 1)
                        {
                            chosenSticks = 1;
                            Console.WriteLine("So you'll have 1 stick, then.");
                        }
                        Sticks -= chosenSticks;

                        if (Sticks <= 0)
                        {
                            Console.WriteLine("Moahaha, you took the last stick! I win!");
                            Console.ReadKey();
                        }
                    }
                }

            }
        }
    }
}
