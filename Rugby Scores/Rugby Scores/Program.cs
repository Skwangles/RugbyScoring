using System;
using System.Collections.Generic;

namespace Rugby_Scores
{
    class Program
    {



        static void Main(string[] args)
        {
            Team A = new Team();
            Team B = new Team();
            Queue<string> events = new Queue<string>();
            Console.WriteLine("Welcome to Rugby Scoring");

            Console.Write("Enter Event: ");
            string entry = Console.ReadLine();

            while (entry != "X")//loops through events until all have been recorded.
            {
                events.Enqueue(entry);//means the calculations can be done once all events have been recorded.
                Console.Write("Enter Event: ");
                entry = Console.ReadLine();

            }

            while (events.Count > 0)//repeats this until all events have been recorded
            {
                string temp = events.Dequeue();
                if (temp.Contains("A"))//checks which team identifier the event has
                {
                    ProcessA(temp);
                }
                else if (temp.Contains("B"))
                {
                    ProcessB(temp);
                }
                else
                {
                    throw new Exception();
                }
            }

            var Apoints = A.points();
            var Bpoints = B.points();
            //modern game calculations
            if (Apoints[0] != Bpoints[0])
            {
                if (Apoints[0] > Bpoints[0])
                {
                    Print("modern", "A");
                }
                else
                {
                    Print("modern", "B");
                }

            }//Checks if draw, else finds the winner
            else
            {
                Console.WriteLine("Modern Result: Draw");
            }

            //old game calculation
            if (Apoints[1] != Bpoints[1])
            {
                if (Apoints[1] > Bpoints[1])
                {
                    Print("old", "A");
                }
                else
                {
                    Print("old", "B");
                }

            }//Checks if draw, else finds the winner through the unconverted tries calculation
            else
            {
                if (A.Unconverted() == B.Unconverted())
                {
                    Console.WriteLine("Old Result: Draw");
                }
                else
                {
                    if (A.Unconverted() > B.Unconverted())
                    {
                        Print("old", "A");
                    }
                    else
                    {
                        Print("old", "B");
                    }
                }
            }












            void Print(string game, string team)
            {
                Console.WriteLine(game + ": " + team + " won.");
            }

            void ProcessA(string temp)
            {
                temp.Replace("A", "");//removes the team identifier so only the event is left.
                switch (temp)//checks what event is being called, and calls correct event. 
                {
                    case "T":
                        A.AddTry();
                        break;
                    case "P":
                        A.AddPenDrop();
                        break;
                    case "C":
                        A.AddConversion();
                        break;
                    case "D":
                        A.AddPenDrop();
                        break;
                    default:
                        throw new Exception();
                }
            }

            void ProcessB(string temp)
            {
                temp.Replace("B", "");

                switch (temp)//checks what event is being called, and calls correct event. 
                {
                    case "T":
                        B.AddTry();
                        break;
                    case "P":
                        B.AddPenDrop();
                        break;
                    case "C":
                        B.AddConversion();
                        break;
                    case "D":
                        B.AddPenDrop();
                        break;
                    default:
                        throw new Exception();
                }
            }
        }






    }
}
