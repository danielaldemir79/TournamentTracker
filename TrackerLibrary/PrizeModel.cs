namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Representerar det nummer som indikerar vilken plats i turneringen priset är för.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Representerar namnet på den plats i turneringen som priset är för.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Representerar det belopp som priset är värt.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Representerar den procentandel av det totala priset som priset är värt.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}