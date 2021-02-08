using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public int CustomerId { get; set; }
        public string Address { get; set; }
    }
}