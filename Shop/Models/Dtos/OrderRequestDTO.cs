namespace Shop.Models.Dtos
{
    public class OrderRequestDTO
    {
        public DateTime OrderDate { get; set; }
      
        public List<ProductOrderRequestDTO> ProductOrders { get; set; } = new List<ProductOrderRequestDTO>();
    }

}
