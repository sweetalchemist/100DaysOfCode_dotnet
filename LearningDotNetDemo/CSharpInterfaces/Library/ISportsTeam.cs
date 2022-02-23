using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public interface ISportsTeam
    {
        int NumberOfPlayers { get; set; }
        string Score { get; set; }
        string TimeLimit { get; set; }
        string Name { get; set; }

        public string GetTeamName()
        {
            return Name;
        }
        int GetNumberOfPlayers();
        string DoActivity();
        string WhenIsGameOver();
    }
}
