using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public class ConcreteSportsTeam
    {
        public int NumberOfPlayers { get; set; }
        public string Name { get; set; }
        public string Score { get; set; }

        public string TimeLimit { get; set; }

        public ConcreteSportsTeam()
        {

        }
        public ConcreteSportsTeam(string name,int numberOfPlayers, string score, string timeLimit)
        {
            NumberOfPlayers = numberOfPlayers;
            Score = score;
            TimeLimit = timeLimit;
            Name = name;

        }

        public string GetTeamName()
        {
            return Name;
        }
        public int GetNumberOfPlayers()
        {
            return NumberOfPlayers;
        }

        public virtual string DoActivity()
        {
            return $"Game scored using {Score}";
        }

        public virtual string WhenIsGameOver()
        {
            return $"Game is over when one team has more {Score} than the other within {TimeLimit}";
        }
    }
}
