using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    class Stock
    {

        // each Stock has properties like name, number od shares and share price.
        // this stocks are stored in

        public string stockName { get; set; }
        public int numberOfStocks { get; set; }
        public float stockPrice { get; set; }

        public static List<Stock> stockList = new List<Stock>();

        // View the Stocks available in the Market

        public void StockView()
        {
            try
            {
                //float totalStockvalue =0 
                float totalStockValue = 0;
                float valueOfStock;
                Console.WriteLine();
                Console.WriteLine("\t\t\tStock Market");
                Console.WriteLine();
                Console.WriteLine("Stock Name   Number of Shares   Share Price in .Rs  Value of Stock in.Rs");
                //foreach loop 
                foreach (Stock st in stockList)
                {
                    Console.WriteLine();
                    //print Op value
                    Console.WriteLine($"{st.stockName}\t\t{st.numberOfStocks}\t\t\t{st.stockPrice} \t\t" +
                        $"{valueOfStock = ValueOfStock(st.stockPrice, st.numberOfStocks)}");
                    // Increment totalstockvalue with total value
                    totalStockValue += TotalValue(valueOfStock);
                }
                Console.WriteLine("---------------------------------------------------------------------");
                //OP total stock value
                Console.WriteLine($"Total Stock Value(.Rs)\t\t\t\t\t{totalStockValue}");
            }
            // for error 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        // methods to calculate total value and value of each stocks

        public float ValueOfStock(float shareprice, int numberOfShares)
        {
            float valueOfStock = shareprice * numberOfShares;
            return valueOfStock;
        }
        // methods to calculate total value and value
        public float TotalValue(float valueOfStock)
        {
            float totalValueOfStocks = +valueOfStock;
            return totalValueOfStocks;
        }
    }
}