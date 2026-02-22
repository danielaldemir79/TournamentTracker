using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            Connections = new List<IDataConnection>();
            
            if (database)
            {
                //Uppkoppling till SQL-databasen 
                SqlConnector sql = new SqlConnector(); 
               Connections.Add(sql);
            }

            if (textFiles)
            {
                //Uppkoppling till textfilerna
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
