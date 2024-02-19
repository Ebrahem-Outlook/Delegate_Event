
namespace Delegate_Event
{
    public delegate void ChangedEvent(decimal oldPrice, decimal newPrice);
    public delegate bool ChangePrice(decimal oldPrice, decimal newPrice);
    public class Program
    {
        public static void Main(String[] args)
        {

        }
    }


    public class BroadCastor
    {
        private decimal price;

        public event ChangedEvent PriceChanged;

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (this.price == value)
                    return;
                decimal oldPrice = this.price;
                this.price = value;
                if (PriceChanged != null)
                    PriceChanged(oldPrice, this.price);
            }
        }
    }


    public class Stock
    {
        private string name;
        private decimal price;
        public event ChangePrice PriceChanged;
        public string Name => this.name;
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (this.price == value) return;
                decimal oldPrice = this.price;
                this.price = value;
                if (PriceChanged != null)
                    PriceChanged(oldPrice, this.price);
            }
        }
    }

}