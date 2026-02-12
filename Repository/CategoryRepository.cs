using YumBlazor.Data;
using YumBlazor.Repository.IRepository;

namespace YumBlazor.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Category Get(int id)
        {
            var obj = _db.Category.FirstOrDefault(c => c.Id == id);
            if(obj == null)
            {
                return new Category();
            }
            return obj;
        }
        public Category Create(Category obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
            return obj;
        }
        public Category Update(Category obj)
        {
           var objFromDB = _db.Category.FirstOrDefault(c => c.Id == obj.Id);
            if(objFromDB != null)
            {
                obj.Name = obj.Name;
                _db.Category.Update(objFromDB);
                _db.SaveChanges();
                return obj;
            }
            return obj;
        }
        public bool Delete(int id)
        {
            var obj = _db.Category.FirstOrDefault(c => c.Id == id);
            if(obj != null)
            {
                _db.Remove(obj);
                return _db.SaveChanges() > 0;
            }

            return false;
        }
        public IEnumerable<Category> GetAll()
        {
            return _db.Category.ToList();
        }
    }
}
