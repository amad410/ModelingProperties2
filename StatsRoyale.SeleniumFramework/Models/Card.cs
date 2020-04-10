using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsRoyale.SeleniumFramework.Models
{
    /// <summary>
    /// This is the abstract base card model class who hase initial values for its properties
    /// but they can be changed by an inherited class to reflect what we get from the UI the moment we navigate to the
    /// Card Details page.  
    /// </summary>
    public abstract class Card
    {
        public string Name { get; set; } = "Mirror";
        public int Cost { get; set; } = 1;
        public string RarityStatus { get; set; } = "Epic";

        public string Category { get; set; } = "Spell";

        public string Arena { get; set; } = "Arena 12";


    }
}
