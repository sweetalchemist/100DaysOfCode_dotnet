using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public abstract class AbstractSportsTeam
    {
        public int NumberOfPlayers { get; set; }
        public string Score { get; set; }

        public string TimeLimit { get; set; }

        public string Name { get; set; }

        public AbstractSportsTeam()
        {

        }
        public AbstractSportsTeam(string name, int numberOfPlayers, string score, string timeLimit)
        {
            NumberOfPlayers = numberOfPlayers;
            Score = score;
            TimeLimit = timeLimit;
            Name = name;
        }
        public int GetNumberOfPlayers()
        {
            return NumberOfPlayers;
        }

        public string GetTeamName()
        {
            return Name;
        }

        public  string DoActivity()
        {
            return Score;
        }

        public abstract string WhenIsGameOver();
    }
}
