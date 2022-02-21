using RepositoryPattern.Application.EntitiesCQ.Categorys.Interfaces;
using RepositoryPattern.Domain;
using RepositoryPattern.Domain.Models.VM;
using RepositoryPattern.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern.Application.EntitiesCQ.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext db;

        public CategoryRepository(AppDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public void Create(CreateCategoryVm categoryVm)
        {
            Category category = new Category()
            {
                Name = categoryVm.Name
            };

            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Update(UpdateCategoryVm categoryVm)
        {
            Category category = new Category()
            {
                CategoryId = categoryVm.CategoryId,
                Name = categoryVm.Name
            };

            db.Categories.Update(category);
            db.SaveChanges();
        }

        public void Delete(Category category)
        {
            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }
}
