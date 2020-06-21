using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the position in number.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the position name.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize amount for
        /// the position.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the prize percentage.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
