namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Representerar en lista av lag som tävlar i matchupen. 
        /// Varje lag representeras av en MatchupEntryModel, 
        /// som innehåller information om laget och dess resultat i matchupen.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Representerar det vinnande laget i matchupen.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Representerar vilken runda i turneringen matchupen tillhör.
        /// </summary>
        public int MatchUpRound { get; set; }
    }
}