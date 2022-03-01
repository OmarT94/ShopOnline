namespace ShopOnline.Api.Entities
{
    public class ProductToAddDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
         public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string GetPreisAsString()
        {
            return string.Format($"{Price} $");
        }
    }
}
