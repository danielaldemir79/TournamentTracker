namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Representerar ett  lag som tävlar i matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Representerar det matchresultat som laget har i matchupen.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Representerar den matchup som laget kommer ifrån. 
        /// Denna används för att kunna spåra tillbaka i turneringen och se vilka lag som tävlar mot varandra i varje matchup.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}