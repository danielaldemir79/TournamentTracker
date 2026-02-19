using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Representerar namnet på turneringen.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Representerar den avgift som varje lag måste betala för att delta i turneringen.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Representerar en lista av lag som har anmält sig till turneringen.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Representerar en lista av priser som är kopplade till turneringen. 
        /// Varje pris representeras av en PrizeModel,
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Representerar en lista av rundor i turneringen.
        /// </summary>
        public List<MatchupModel> Rounds { get; set; } = new List<MatchupModel>();

    }
}
