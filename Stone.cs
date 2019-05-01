using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int gameChoice;
            string[] choice = { "Scissors","Paper","Stone" };
            Random randam = new Random();
            Console.WriteLine("\t\t\t\t/******* STONE PAPER SCISSOR*******/");
            int cpu_points = 0, your_points = 0;
            string yes_no;
            do
            {
                Console.WriteLine();
                Console.Write("Enter your Choice ");
                Console.Write("1. Scissors ");
                Console.Write("2. Paper ");
                Console.Write("3. Stone ");
                Console.WriteLine();
                gameChoice = int.Parse(Console.ReadLine());
                if (gameChoice > 3 || gameChoice < 1)
                    Console.WriteLine("Wrong Input");
                else
                {
                    Console.WriteLine("Your Choice is " + choice[gameChoice - 1]);
                    int ranPos = randam.Next(choice.Length);
                    string cpuChoice = choice[ranPos];
                    Console.WriteLine("CPU choice is " + choice[ranPos]);
                    ranPos++;
                    if (ranPos == gameChoice)
                        Console.WriteLine("Game Draw");
                    else if (ranPos == 1 && gameChoice == 2)
                    {
                        Console.WriteLine("CPU Won");
                        cpu_points++;
                    }
                    else if (ranPos == 2 && gameChoice == 1)
                    {
                        Console.WriteLine("You Won");
                        your_points++;
                    }
                    else if (ranPos == 1 && gameChoice == 3)
                    {
                        Console.WriteLine("You Won");
                        your_points++;
                    }
                    else if (ranPos == 3 && gameChoice == 1)
                    {
                        Console.WriteLine("CPU Won");
                        cpu_points++;
                    }
                    else if (ranPos == 2 && gameChoice == 3)
                    {
                        Console.WriteLine("CPU Won");
                        cpu_points++;
                    }
                    else if (ranPos == 3 && gameChoice == 2)
                    {
                        Console.WriteLine("You Won");
                        your_points++;
                    }
                    else
                        Console.Write("Wrong Input");
                }
                Console.WriteLine("Your Points " + your_points);
                Console.WriteLine("CPU Points " + cpu_points);
                Console.WriteLine("Do you want to play again y/n");
                yes_no = Console.ReadLine();
            } while (string.Compare(yes_no,"y")==0);
            Console.ReadKey();
        }
    }
}
