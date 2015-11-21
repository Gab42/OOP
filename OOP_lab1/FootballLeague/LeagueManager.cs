﻿using System;
using System.Globalization;

namespace FootballLeague
{
    static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split(' ');
            switch(inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    Console.WriteLine("Team successfully added.");
                    break;
                case "AddMatch":
                    AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    Console.WriteLine("Match successfully added.");
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4], CultureInfo.InvariantCulture), inputArgs[5]);
                    Console.WriteLine("Player successfully added.");
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMatches();
                    break;                 
            }
        }

        private static void AddTeam(string name, string nickname, DateTime dateOfFounding)
        {
            // AddTeam ManUnited TheRedDevils 1878-4-8
            League.AddTeam(new Team(name, nickname, dateOfFounding));
        }

        private static void AddMatch(int id, string hometeam, string awayteam, int home, int away)
        {
            // AddMatch 1 ManUnited Arsenal 3 0
            League.AddMatch(new Match(StringToTeam(hometeam), StringToTeam(awayteam), new Score(home, away), id));
        }

        private static void AddPlayerToTeam(string firstname, string lastname, DateTime dateOfBirth, decimal salary, string team)
        {
            // AddPlayerToTeam Leo Messi 1986-2-12 30000.00 Southampton
            StringToTeam(team).AddPlayer(new Player(firstname, lastname, salary, dateOfBirth));
        }

        private static void ListTeams()
        {
            foreach (var item in League.Teams)
            {
                Console.WriteLine(item);
            }
        }

        private static void ListMatches()
        {
            foreach (var item in League.Matches)
            {
                Console.WriteLine(item);
            }
        }

        private static Team StringToTeam(string teamName)
        {
            foreach (var item in League.Teams)
            {
                if (item.Name == teamName)
                {
                    return item;
                }
            }
            throw new ArgumentException("No such team exists!");
        }
    }
}
