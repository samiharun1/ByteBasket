namespace ByteBasket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Order newOrder = new Order("101", "Dator", "Sami Harun", 9999.99m, DateTime.Now);
                newOrder.ShowOrderDetaljer();
            }
        }
    }
}
