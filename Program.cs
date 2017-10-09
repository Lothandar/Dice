using System;
using System.Windows;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Cup cup = new Cup();
            Die D4 = new Die();
            Die D6 = new Die(6);
            Die D8 = new Die(8);
            Die D10 = new Die(10);
            Die D12 = new Die(12);
            Die D20 = new Die(20);
            ConsoleKey choice;
            bool choosed = false;
            bool run = true;

            Console.WriteLine("Your cup is Empty What dice do you want to do?");
            while(run)
                {
                Console.WriteLine("1) Add a Dice");
                Console.WriteLine("2) Remove a Dice");
                Console.WriteLine("3) Roll the cup content");
                Console.WriteLine("4) Show what's in the cup");
                Console.WriteLine("5) Empty the cup");
                choosed= false;
                    while(!choosed)
                    {
                        choice = Console.ReadKey(true).Key;
                        switch(choice)
                        {
                            case ConsoleKey.D1: 
                            case ConsoleKey.NumPad1:
                            #region AddDice
                            Console.WriteLine("Which Dice do you want to add?");
                            Console.WriteLine("1) D4");
                            Console.WriteLine("2) D6");
                            Console.WriteLine("3) D8");
                            Console.WriteLine("4) D10");
                            Console.WriteLine("5) D12");
                            Console.WriteLine("6) D20");
                            
                            

                            choosed= false;
                            while(!choosed)
                            {
                                try 
                                {
                                    choice = Console.ReadKey(true).Key;

                                    switch (choice)
                                    {
                                        case ConsoleKey.D1: 
                                        case ConsoleKey.NumPad1:
                                        cup.Add(D4);
                                        choosed = true;
                                        break;
                                        case ConsoleKey.D2: 
                                        case ConsoleKey.NumPad2:
                                        cup.Add(D6);
                                        choosed = true;
                                        break;
                                        case ConsoleKey.D3: 
                                        case ConsoleKey.NumPad3:
                                        cup.Add(D8);
                                        choosed = true;
                                        break;
                                        case ConsoleKey.D4: 
                                        case ConsoleKey.NumPad4:
                                        cup.Add(D10);
                                        choosed = true;
                                        break;
                                        case ConsoleKey.D5: 
                                        case ConsoleKey.NumPad5:
                                        cup.Add(D12);
                                        choosed = true;
                                        break;
                                        case ConsoleKey.D6: 
                                        case ConsoleKey.NumPad6:
                                        cup.Add(D20);
                                        choosed = true;
                                        break;
                                        case ConsoleKey.Escape:
                                        Environment.Exit(0);
                                        break;
                                    }
                                }
                                catch
                                {
                                    
                                }
                            }
                            #endregion
                            choosed = true;
                            break;
                            case ConsoleKey.D2: 
                            case ConsoleKey.NumPad2:
                
                            choosed = true;
                            break;
                            case ConsoleKey.D3: 
                            case ConsoleKey.NumPad3:
                            cup.Roll();
                            choosed = true;
                            break;
                            case ConsoleKey.D4: 
                            case ConsoleKey.NumPad4:
                            cup.Show();
                            choosed = true;
                            break;
                            case ConsoleKey.D5: 
                            case ConsoleKey.NumPad5:
                            cup.Empty();
                            choosed = true;
                            break;
                            case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        }
                    }
                }
            }
        }
}
