using System;

namespace FootballLeague
{
    class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(Team hometeam, Team awayteam, Score score, int id)
        {
            this.HomeTeam = hometeam;
            this.AwayTeam = awayteam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam
        {
            get
            {
                return this.homeTeam;
            }
            set
            {
                homeTeam = value;
            }
        }

        public Team AwayTeam
        {
            get
            {
                return this.awayTeam;
            }
            set
            {
                if (this.homeTeam.Name.Equals(value.Name))
                {
                    throw new ArgumentException("The names of the teams in a match cannot be the same!");
                }
                awayTeam = value;
            }
        }

        public Score Score
        {
            get
            {
                return this.score;
            }
            set
            {
                score = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                id = value;
            }
        }

        public Team GetWinner()
        {
            if (this.IsDraw())
                return null;

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }

        public override string ToString()
        {
            return this.id.ToString() + " " + this.homeTeam.Name + " vs. " + this.awayTeam.Name + " " + this.score.HomeTeamGoals + ":" + this.score.AwayTeamGoals;
        }
    }
}
