using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class ComputerGame
    {
        public string Title { get; private set; }
        public int PegiAgeRating { get; private set; }
        public decimal Budget { get; private set; } // Бюджет в миллионах

        public ComputerGame(string title, int pegiAgeRating, decimal budget)
        {
            Title = title;
            PegiAgeRating = pegiAgeRating;
            Budget = budget;
        }

        public bool IsHighBudget()
        {
            return Budget > 50;
        }
    }

}
