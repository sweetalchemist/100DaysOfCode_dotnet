using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public class BasketBall : AbstractSportsTeam
    {
        public BasketBall(string name) : base(name,5, "Baskets", "4 Quarters")
        {

        }
        public override string WhenIsGameOver()
        {
            return $"One team of {NumberOfPlayers} score more {Score} than the other team of {NumberOfPlayers} within {TimeLimit}";
        }
    }
}
