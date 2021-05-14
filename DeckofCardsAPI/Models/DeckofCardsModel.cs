using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckofCardsAPI.Models
{
    public class DeckofCardsModel
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
        public bool shuffled { get; set; }
    }
}






