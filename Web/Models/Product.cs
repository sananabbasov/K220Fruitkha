namespace Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsDelete { get; set; }
        public decimal Discount { get; set; }
        public DateTime DiscountDate { get; set; }
    }
}