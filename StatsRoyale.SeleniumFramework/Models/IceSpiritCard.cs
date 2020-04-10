using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsRoyale.SeleniumFramework.Models
{
    /// <summary>
    /// This is the model class of the Ice Spirit card containing its properties and values.  
    /// It modifie the property values of the base class Card.cs
    /// </summary>
    public class IceSpiritCard : Card
    {
        
        public string Name { get; set; } = "Ice Spirit";
        public int Cost { get; set; } = 1;
        public string RarityStatus { get; set; } = "Common";

        public string Category { get; set; } = "Troop";

        public string Arena { get; set; } = "Arena 8";
    }
}
