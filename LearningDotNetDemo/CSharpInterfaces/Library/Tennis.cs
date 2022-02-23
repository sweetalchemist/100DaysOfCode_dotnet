using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public class Tennis : ConcreteSportsTeam
    {
        public Tennis(string name) : base(name, 1, "Points and Sets", "5 Sets")
        {

        }

        public override string DoActivity()
        {
            return $"{NumberOfPlayers} player plays using {Score}";
        }

        public override string WhenIsGameOver()
        {
            return base.WhenIsGameOver();
        }
    }
}
