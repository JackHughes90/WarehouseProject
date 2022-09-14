namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Item banana = new Item("banana", 1.50);
            Item apple = new Item("apple", 1.00);
            
            Warehouse warehouse = new Warehouse();
            Basket bobsBasket = new Basket();
            Console.WriteLine("Welcome to our warehouse!");
            Warehouse.WarehouseContents.Add(banana.Name, 1);
        }
    }
}