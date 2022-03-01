using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Repositories
{
    public class ProductRepository : IproductRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;

        public ProductRepository(ShopOnlineDbContext shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }

        public async Task<Product> AddProduct(Product product)
        {
            shopOnlineDbContext.Add(product);
            await shopOnlineDbContext.SaveChangesAsync();
            return product;

        }

        public async Task<Product> DeleteProduct(int id)
        {
            var product = new Product { Id=id };
            shopOnlineDbContext.Remove(product);
            await shopOnlineDbContext.SaveChangesAsync();
            return NoContent();
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
           var categories = await this.shopOnlineDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category =await shopOnlineDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await shopOnlineDbContext.Products.FindAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.shopOnlineDbContext.Products.ToListAsync();
            return products;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
           shopOnlineDbContext.Entry(product).State = EntityState.Modified;
            await shopOnlineDbContext.SaveChangesAsync();
            return NoContent();
        }

        private Product NoContent()
        {
            throw new NotImplementedException();
        }
    }
}
