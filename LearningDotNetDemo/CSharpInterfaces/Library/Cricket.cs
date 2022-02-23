using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public class Cricket : ISportsTeam
    {
        public int NumberOfPlayers { get ; set ; }
        public string Score { get ; set ; }
        public string TimeLimit { get ; set ; }
        public string Name { get ; set ; }

        public Cricket(string name)
        {
            Name = name ;
            NumberOfPlayers = 11;
            Score = "Runs and Wickets";
            TimeLimit = "50 Overs";
        }

        public string DoActivity()
        {
            return Score;
        }

        public int GetNumberOfPlayers()
        {
            return NumberOfPlayers;
        }

        public string WhenIsGameOver()
        {
            return $"Game is over when one team of {NumberOfPlayers} creates more {Score} than the other within {TimeLimit}";   
        }
    }
}
