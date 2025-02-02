using System;

namespace MobileRepairShop.Models
{
    public class History
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int QuantitySold { get; set; }
        public DateTime SaleDate { get; set; }
    }
}