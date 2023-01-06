using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class StockDetails
    {
        public List<StocksList> stocksList;
    }

    public class StocksList
    {
        public string StockName;
        public int Shares;
        public int Price;
    }
}
