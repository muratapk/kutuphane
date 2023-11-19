using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TAdd(Categories entity)
        {
            _categoryDal.Add(entity);
        }

        public void TDelete(Categories entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Categories> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Categories TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TUpdate(Categories entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
