using System;
using System.Collections.Generic;

class program
{
    static Dictionary<string, int> candidates = new Dictionary<string, int>();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Voting Application");

        InitializeCandidates();

        bool votingOpen = true;
        while (votingOpen)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Vote");
            Console.WriteLine("2. View Results");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {

                case "1":
                    Vote();
                    break;

                case "2":
                    ViewResults();
                    break;

                case "3":
                    votingOpen = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;


            }

        }
        Console.WriteLine("Thank you for participating");
    }
    static void InitializeCandidates()
    {
        candidates.Add("Shandu", 0);
        candidates.Add("Alice", 0);
        candidates.Add("Bob", 0);
    }
    static void Vote()
    {
        Console.WriteLine("\nWho would you like to vote for?");
        foreach (var candidate in candidates.Keys)
        {
            Console.WriteLine(candidate);
        }

        string vote = Console.ReadLine();

        if (candidates.ContainsKey(vote))
        {
            candidates[vote]++;
            Console.WriteLine($"Thank you for voting for {vote}!");
        }
        else
        {
            Console.WriteLine("Invalid candidate. Please try again.");
        }
    }
    static void ViewResults()
    {
        Console.WriteLine("\nVotingResults:");
        foreach (var candidate in candidates)
        {
            Console.WriteLine($"{candidate.Key}: {candidate.Value} votes");
        }
    }
}