using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern  
{
    public class ComputerGameAdapter : PCGame
    {
        private readonly ComputerGame _computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            _computerGame = computerGame;
        }

        public string GetTitle()
        {
            return _computerGame.Title;
        }

        public int GetPegiAgeRating()
        {
            return _computerGame.PegiAgeRating;
        }

        public bool IsTripleA()
        {
            return _computerGame.IsHighBudget();
        }
    }
}
