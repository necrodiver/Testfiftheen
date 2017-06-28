using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FirstCodeFirstDemo
{
    public class FirstCodeFirstApp
    {
        public class Context : DbContext
        {
            public Context() : base("name=FirstCodeFirstApp")
            {

            }
            public DbSet<Donator> Donators { get; set; }
        }
    }
    public class Donator
    {
        [Key]
        public int DonatorId { get; set; }
        [StringLength(200, MinimumLength = 2)]
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonateDate { get; set; }
    }

}
