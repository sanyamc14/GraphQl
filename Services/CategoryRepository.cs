using Microsoft.EntityFrameworkCore;
using NewGraphQL.Data;
using NewGraphQL.Interfaces;
using NewGraphQL.Model;

namespace NewGraphQL.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private GraphQLDbContext _dbContext;
        public CategoryRepository(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Category AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var categoryResult = _dbContext.Categories.Find(id);
            _dbContext.Categories.Remove(categoryResult);
            _dbContext.SaveChanges();
        }

        public List<Category> GetCategories()
        {
           return _dbContext.Categories.ToList();
        }

        public Category UpdateCategory(int id, Category category)
        {
            var categoryResult = _dbContext.Categories.Find(id);
            categoryResult.Name = category.Name;
            categoryResult.ImageUrl = category.ImageUrl;           
            _dbContext.SaveChanges();

            return category;
        }
    }
}
