namespace ShopOnline.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }

        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string? CategoryName { get; set; }
        public int Qty { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? productImageURL { get; set; }
        public decimal? Price { get; set; }

    }
}
