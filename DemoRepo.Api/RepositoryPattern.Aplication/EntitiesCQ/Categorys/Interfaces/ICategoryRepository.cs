using RepositoryPattern.Domain;
using RepositoryPattern.Domain.Models.VM;
using System.Collections.Generic;

namespace RepositoryPattern.Application.EntitiesCQ.Categorys.Interfaces
{
    public interface ICategoryRepository
    {

        public void Create(CreateCategoryVm categoryVm);

        public void Update(UpdateCategoryVm categoryVm);


        public IEnumerable<Category> GetAll();

        public Category GetById(int id);

        public void Delete(Category product);
    }
}
