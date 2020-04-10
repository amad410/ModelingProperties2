using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsRoyale.SeleniumFramework.Models
{
    /// <summary>
    /// This is the model class of the Mirror card containing its properties and values.  
    /// It overrides the property values of the base class Card.cs
    /// </summary>
    public class MirrorCard : Card
    {
        public string Name { get; set; } = "Mirror";
        public int Cost { get; set; } = 1;
        public string RarityStatus { get; set; } = "Epic";

        public string Category { get; set; } = "Spell";

        public string Arena { get; set; } = "Arena 12";
    }
}
