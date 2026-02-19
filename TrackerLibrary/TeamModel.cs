using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Representerar en lista av personer som är medlemmar i laget.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Representerar namnet på laget.
        /// </summary>
        public string TeamName { get; set; }
        
    }
}
