namespace Shop.Models.Dtos
{
    public class OrderSummaryDto
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int OrderCount { get; set; }
        public int ProductCount { get; set; }
    }
}
