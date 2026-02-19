using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Representerar personens förnamn.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Representerar personens efternamn.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Representerar personens e-postadress.
        /// </summary>
        public string EmailAdress { get; set; }

        /// <summary>
        /// Representerar personens mobilnummer.
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
