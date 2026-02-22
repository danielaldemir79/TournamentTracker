using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    internal class TextConnection : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
