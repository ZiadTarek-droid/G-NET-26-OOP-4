using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ticket
    {
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }

        public decimal TaxRate = 0.14m;

        public decimal PriceAfterTax
        {
            get { return Price + (Price * TaxRate); }
        }

        // Method Overloading
        public void SetPrice(decimal price)
        {
            Price = price;
            Console.WriteLine("Setting price directly: " + price);
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price}");
        }

        // Virtual Method
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }
    }

    
}
