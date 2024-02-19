
namespace Delegate_Event
{
    public delegate void ChangePrice(string Name, decimal oldPrice, decimal newPrice);
    public class Program
    {
        public static void Main(String[] args)
        {
            Stock stock = new Stock("Amazoun");
            stock.EventPrice += Stock1_EventPrice;
            stock.Price = 100;
            stock.ChangeStockPrice(-0.05M);


            Stock stock1 = new Stock("Microsoft");
            stock1.EventPrice += Stock1_EventPrice;
            stock1.Price = 250;
            stock1.ChangeStockPrice(0.05M);

            Stock stock2 = new Stock("Apple");
            stock2.EventPrice += Stock1_EventPrice;
            stock2.Price = 300;
            stock2.ChangeStockPrice(0.1M);

            Stock stock3 = new Stock("Meta");
            stock3.EventPrice += Stock1_EventPrice;
            stock3.Price = 250;
            stock3.ChangeStockPrice(0.15M);

        }


        // subscribe Event
        private static void Stock1_EventPrice(string Name, decimal oldPrice, decimal newPrice)
        {
            if (newPrice > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Name:: {Name} | OldPrice:: {oldPrice} | newPrice:: {newPrice} ");
            }
            else if(newPrice < oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Name:: {Name} | OldPrice:: {oldPrice} | newPrice:: {newPrice} ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Name::  {Name}  | OldPrice:: {oldPrice} | newPrice:: {newPrice} ");
            }
        }
    }

    public class Stock
    {
        public string Name { get; }   
        public decimal Price { get; set;}

        public event ChangePrice EventPrice;

        public Stock(string _name)
        {
            Name = _name;
        }

        public void ChangeStockPrice(decimal percent)
        {
            decimal oldPrice = Price;
            Price += Math.Round(Price * percent,2);
            if (EventPrice != null)
                EventPrice(Name, oldPrice, Price);
        }
    }
}