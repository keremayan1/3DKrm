using KRM3D.Core.Utilities.Results;
using KRM3D.Services.Catalog.Entities.Concrete;
using KRM3D.Services.Catalog.Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Catalog.Business.Abstract
{
    public interface ICategoryService
    {
        Task<IResult> CreateAsync(CategoryDto category);
        Task<IDataResult<CategoryDto>> GetByIdAsync(string id);


        Task<IDataResult<IEnumerable<CategoryDto>>> GetAllAsync();

        Task<IResult> DeleteAsync(string id);
        Task<IResult> UpdateAsync(CategoryDto category);
       

    }
}
