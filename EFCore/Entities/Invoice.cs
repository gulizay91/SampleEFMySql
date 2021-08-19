using System;
namespace SampleEFMySql.EFCore.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Vkn { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
