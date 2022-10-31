using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubCategoryService
    {
        void AddSubCategory(SubCategory subCategory, List<int> categoryIds);
        List<SubCategory> GetAllSubCategories();
    }
}
