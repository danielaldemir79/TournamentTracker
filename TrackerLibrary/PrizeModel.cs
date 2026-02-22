namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize. This is typically used as a primary key in a database.
        /// </summary>
        public int Id { get; set; } 
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

        public PrizeModel()
        {
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        { 
             PlaceName = placeName;
             PlaceNumber = int.Parse(placeNumber);
             PrizeAmount = decimal.Parse(prizeAmount);
             PrizePercentage = double.Parse(prizePercentage);
        }
    }
}