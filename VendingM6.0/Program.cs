using VendingM6._0.Data;

namespace VendingM6._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.ListOfProducts();
            Console.WriteLine(vendingMachine.ShowAll());
        }
    }
}