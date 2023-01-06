namespace StockAccountManagement
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string path = "J:\\240\\StockAccountManagement\\StockAccountManagement\\Jsonfile.json";

            ReadData readData = new ReadData();

            var Data = readData.Read(path);

            Console.WriteLine("Types of Stocks");
            Console.WriteLine("-------------------");
            for (int i = 0; i < Data.stocksList.Count; i++)
            {
                Console.WriteLine(Data.stocksList[i].StockName);
                Console.WriteLine(Data.stocksList[i].Shares);
                Console.WriteLine(Data.stocksList[i].Price);
                Console.WriteLine("-------------------");
                int val = Data.stocksList[i].Shares * Data.stocksList[i].Price;
                Console.WriteLine("The Price for " + Data.stocksList[i].Shares + "Shares is " + val);
                Console.WriteLine("-------------------");
            }

        }
    }
}
