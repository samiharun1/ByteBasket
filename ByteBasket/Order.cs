using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Product { get; set; }
        public string KundNamn { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDatum { get; set; }


        public Order(int orderid, string Prodct, string kundnamn, decimal totalPrice, DateTime orderdatum) 
        {
            OrderId = orderid;
            Product = Prodct;
            KundNamn = kundnamn;
            TotalPrice = totalPrice;
            OrderDatum = DateTime.Now; // rikigta datum 

        }
        public void ShowOrderDetaljer()
        {
            Console.WriteLine($"Order-ID: {OrderId}");
            Console.WriteLine($"Produkt: {Product}");
            Console.WriteLine($"Kund: {KundNamn}");
            Console.WriteLine($"Total Pris: {TotalPrice:C}");
            Console.WriteLine($"Orderdatum: {OrderDatum}");
        }
    }

}

