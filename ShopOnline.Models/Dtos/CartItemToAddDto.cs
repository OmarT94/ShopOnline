using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    public class CartItemToAddDto
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string? CategoryName { get; set; }
        public int Qty { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? productImageURL { get; set; }
        public decimal Price { get; set; }

    }
}