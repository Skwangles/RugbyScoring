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

            while(entry != "X")
            {
                events.Enqueue(entry);
                Console.Write("Enter Event: ");
                entry = Console.ReadLine();

            }
        }

       
       



    }
}
