using Microsoft.EntityFrameworkCore;
using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Product> GetAsync(int id)
        {
            var obj = await _db.Product.FirstOrDefaultAsync(c => c.Id == id);
            if(obj == null)
            {
                return new Product();
            }
            return obj;
        }
        public async Task<Product> CreateAsync(Product obj)
        {
            await _db.Product.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }
        public async Task<Product> UpdateAsync(Product obj)
        {
           var objFromDB = await _db.Product.FirstOrDefaultAsync(c => c.Id == obj.Id);
            if(objFromDB != null)
            {
                obj.Name = obj.Name;
                obj.Description = obj.Description;
                obj.Price = obj.Price;
                obj.SpecialTag = obj.SpecialTag;
                obj.CategoryId = obj.CategoryId;
                obj.ImageUrl = obj.ImageUrl;
                obj.CategoryId = obj.CategoryId;
                _db.Product.Update(objFromDB);
                await _db.SaveChangesAsync();
                return obj;
            }
            return obj;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var obj = await _db.Product.FirstOrDefaultAsync(c => c.Id == id);
            if(obj != null)
            {
                _db.Product.Remove(obj);
                return (await _db.SaveChangesAsync()) > 0;
            }

            return false;
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _db.Product.ToListAsync();
        }
    }
}
