using System;

namespace FootballLeague
{
    class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int hometeamgoals, int awayteamgoals)
        {
            this.AwayTeamGoals = awayteamgoals;
            this.HomeTeamGoals = hometeamgoals;
        }

        public int AwayTeamGoals
        {
            get
            {
                return this.awayTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Away team goals cannot be a negative number!");
                }
                awayTeamGoals = value;
            }
        }

        public int HomeTeamGoals
        {
            get
            {
                return this.homeTeamGoals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Home team goals cannot be a negative number!");
                }
                homeTeamGoals = value;
            }
        }
    }
}
