using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock
            {
                stockName = "Oracle",
                numberOfStocks = 100,
                stockPrice = 20
            };
            Stock stock1 = new Stock
            {
                stockName = "Infosys",
                numberOfStocks = 50,
                stockPrice = 30
            };
            Stock stock2 = new Stock
            {
                stockName = "TCS",
                numberOfStocks = 1000,
                stockPrice = 50
            };
            Stock stock3 = new Stock
            {
                stockName = "HCL",
                numberOfStocks = 500,
                stockPrice = 100
            };
            Stock stock4 = new Stock
            {
                stockName = "Airtel",
                numberOfStocks = 1000,
                stockPrice = 40
            };

            Stock.stockList.Add(stock);
            Stock.stockList.Add(stock1);
            Stock.stockList.Add(stock2);
            Stock.stockList.Add(stock3);
            Stock.stockList.Add(stock4);
            stock.StockView();
            //Portfolio 
            StockPortFolio stockPortfolio = new StockPortFolio
            {
                StockHolder = "Shreya",
                portStockName = new string[5] { "Oracle", "Infosys", "TCS", "HCL", "Airtel" },
                portNumberOfShare = new int[5] { 10, 22, 34, 49, 55 },
                protStockPrice = new float[5] {stock.stockPrice, stock1.stockPrice,stock2.stockPrice,
                stock3.stockPrice,stock4.stockPrice}
            };
            StockPortFolio.stockPortfolioList.Add(stockPortfolio);
            //displaying the stock portfolio
            stockPortfolio.PortFolioView();
            //writing the portfolio account to file
            stockPortfolio.WriteFile();
            Console.WriteLine("File Write Successful");
            Console.ReadLine();

        }
    }
}
