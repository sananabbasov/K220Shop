using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        private readonly ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public void AddSubCategory(SubCategory subCategory, List<int> categoryIds)
        {
            _subCategoryDal.AddSubCategoryWithCategories(subCategory, categoryIds);
        }

        public List<SubCategory> GetAllSubCategories()
        {
            return _subCategoryDal.GetAll();
        }
    }
}
