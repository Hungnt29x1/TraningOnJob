using DAL_CodeFirst.DomainClass;
using System;
using System.Collections.Generic;

namespace B7_DesignPattern.Services.InterfaceServices
{
    public interface ICategoriesService
    {
        public bool Create(Category cv);

        public bool Update(Guid id, Category cv);

        public bool Delete(Guid id);

        public List<Category> GetAll();
    }
}
