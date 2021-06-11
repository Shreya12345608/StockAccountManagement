using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StockAccountManagement
{
    class StockPortFolio
    {

        // Managing Portfolio of person holding stocks of various companies

        public string StockHolder { get; set; }
        public string[] portStockName { get; set; }
        public int[] portNumberOfShare { get; set; }
        public float[] protStockPrice { get; set; }

        public static List<StockPortFolio> stockPortfolioList = new List<StockPortFolio>();
        Stock stock = new Stock();

        /// <summary>
        /// view format for portfolio,
        /// calculating value of each stock and total value of stocks.
        /// </summary

        public void PortFolioView()
        {
            try
            {
                int i = 0;
                float portValueOfStocks, portTotalValue = 0;
                Console.WriteLine();
                foreach (StockPortFolio sp in stockPortfolioList)
                {
                    Console.WriteLine("PortFolio of " + sp.StockHolder);
                    Console.WriteLine("Stock name\tNumber of Shares\tValue of Stocks(.Rs)");
                    while (i <= 4)
                    {
                        Console.WriteLine();
                        Console.Write(sp.portStockName[i] + "\t\t  ");
                        Console.Write(sp.portNumberOfShare[i] + "\t\t\t  ");
                        portValueOfStocks = stock.ValueOfStock(sp.protStockPrice[i], sp.portNumberOfShare[i]);
                        Console.WriteLine(portValueOfStocks);
                        portTotalValue += stock.TotalValue(portValueOfStocks);
                        i++;
                    }
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine($"Total Value(.Rs)\t\t\t  {portTotalValue} ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// using streamwriter for writing details to file from list
        /// </summary>
        public void WriteFile()
        {
            //file path for writing and reading details
            try
            {
                string filepath = @"C:\Users\hp\Desktop\BriLabz\StockAccountManagement\StockAccountManagement\StockReport.txt";

                using (StreamWriter streamWriter = new StreamWriter(filepath))
                {
                    int i = 0;
                    foreach (StockPortFolio st in stockPortfolioList)
                    {
                        streamWriter.Write(st.StockHolder + "\t" + st.portStockName[i] + "\t" + st.portNumberOfShare[i]);
                        //   streamWriter.Write(st.portStockName[i] + "\t" + st.portNumberOfShare[i]);
                        //while (i <= 4)
                        //    streamWriter.Write(st.StockHolder);
                        //streamWriter.Write(st.portStockName[i] + "\t" + st.portNumberOfShare[i]);
                        //i++;
                    }

                    streamWriter.Close();
      

        }
               
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
          
            

        }
        // streamWriter.WriteLine(StockHolder);
        //int i = 0;

    }
}
