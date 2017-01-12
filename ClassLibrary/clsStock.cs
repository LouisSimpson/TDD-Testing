using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public string Stock { get; set; }
        public int stockLevel { get; set; }
       

        public bool valid(string stockName)
        {
            if ( stockName.Length == 0)
            {
                return false;
            }
            if (stockName.Length > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       

        public bool valid2(int StockLevel)
        {
            if ( StockLevel == -1 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}