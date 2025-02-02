using System;

namespace MobileRepairShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public int TotalItems { get; set; }
        public int AvailableItems { get; set; }
        public int SoldItems { get; set; }
    }
}