using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague
{
    class Team
    {
        private string name;
        private string nickname;
        private DateTime dateOfFounding;
        private List<Player> players = new List<Player>();

        public Team(string name, string nickname, DateTime dateOfFounding)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateOfFounding = dateOfFounding;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Count() < 5)
                {
                    throw new ArgumentException("Name must be at least 5 characters long!");
                }
                this.name = value;
            }
        }

        public string Nickname
        {
            get
            {
                return this.nickname;
            }
            set
            {
                if (value.Count() < 5)
                {
                    throw new ArgumentException("Nickname must be at least 5 characters long!");
                }
                this.nickname = value;
            }
        }

        public DateTime DateOfFounding
        {
            get
            {
                return this.dateOfFounding;
            }
            set
            {
                this.dateOfFounding = value;
            }
        }

        public List<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (PlayerAddCheck(player))
            {
                throw new InvalidOperationException("Player already exists in this team!");
            }
            this.players.Add(player);
            player.Team = this;
        }

        private bool PlayerAddCheck(Player player)
        {
            return this.Players.Any(p => p.Firstname == player.Firstname && p.Lastname == player.Lastname);
        }

        public override string ToString()
        {
            return this.Name + " - " + string.Join(", ", players.Select(z => z.ToString()));
        }

    }
}
