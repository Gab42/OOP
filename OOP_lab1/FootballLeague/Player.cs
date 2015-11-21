using System;
using System.Linq;

namespace FootballLeague
{
    class Player
    {
        private const int minimumAllowedYear = 1980;
        private string firstname;
        private string lastname;
        private decimal salary;
        private DateTime dateOfBirth;
        private Team team;

        public Player(string firstname, string lastname, decimal salary, DateTime dateOfBirth)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
        }

        public string Firstname {
            get
            {
                return this.firstname;
            }
            set
            {
                if (value.Count() < 3)
                {
                    throw new ArgumentException("Firstname must be at least 3 characters long!");
                }
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (value.Count() < 3)
                {
                    throw new ArgumentException("Lastname must be at least 3 characters long!");
                }
                lastname = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be a negative number!");
                }
                salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                if (value.Year < minimumAllowedYear)
                {
                    throw new ArgumentException("Date of birth year cannot be earlier than " + minimumAllowedYear + "!");
                }
                dateOfBirth = value;
            }
        }

        public Team Team
        {
            get
            {
                return this.team;
            }
            set
            {
                team = value;
            }
        }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname;
        }
    }
}
