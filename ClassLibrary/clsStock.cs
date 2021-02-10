using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public string Description { get; set; }

        public bool Available { get; set; }

        public DateTime DateAdded { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public int Id { get; set; }
    }
}