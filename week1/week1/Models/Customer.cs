using System;
namespace week1.Models
{

    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();//global eşi ve benzeri olmayan id türetilir
        }
        public Guid Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
