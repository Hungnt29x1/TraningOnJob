using B7_DesignPattern.Services.InterfaceServices;
using DAL_CodeFirst.DomainClass;
using DAL_CodeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace B7_DesignPattern.Services.ClassServices
{
    public class CategoriesService : ICategoriesService
    {
        private IGenericRepositories<Category> _repository;

        public CategoriesService(IGenericRepositories<Category> repository)
        {
            _repository = repository;
        }
        public bool Create(Category cv)
        {
            if (cv == null) return false;
            if (_repository.Add(cv))
            {
                return true;
            }
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == null) return false;
            var result = _repository.GetAll().Where(c=>c.CategoryId == id).FirstOrDefault();
            if (_repository.Delete(result))
            {
                return true;
            }
            return false;
        }

        public List<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Update(Guid id, Category cv)
        {
            if (id == null) return false;
            var result = _repository.GetAll().Where(c => c.CategoryId == id).FirstOrDefault();
            result.CategoryName = cv.CategoryName;
            result.CategoryImage = cv.CategoryImage;
            result.Status = cv.Status;
            if (_repository.Update(result))
            {
                return true;
            }
            return false;
        }
    }
}
