using AutoMapper;
using KRM3D.Core.Aspects.Validation;
using KRM3D.Core.Messages;
using KRM3D.Core.Utilities.Business;
using KRM3D.Core.Utilities.Results;
using KRM3D.Services.Catalog.Business.Abstract;
using KRM3D.Services.Catalog.Business.ValidationRules;
using KRM3D.Services.Catalog.DataAccess.Abstract;
using KRM3D.Services.Catalog.Entities.Concrete;
using KRM3D.Services.Catalog.Entities.Concrete.Dto;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Catalog.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
      private  IMapper _mapper;
        private readonly IPublishEndpoint _publishEndpoint;


        public CategoryManager(ICategoryDal categoryDal, IMapper mapper, IPublishEndpoint publishEndpoint)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
            _publishEndpoint = publishEndpoint;
        }
        [ValidationAspect(typeof(CategoryDtoValidator))]
        public async Task<IResult> CreateAsync(CategoryDto category)
        {
            var categories = _mapper.Map<Category>(category);
            await _categoryDal.AddAsync(categories);
            return new SuccessResult("Islem Basarili");

        }

        public async Task<IResult> DeleteAsync(string id)
        {
            var result = BusinessRules.Run(CheckIfCategoryIdExists(id));
            if (result!=null)
            {
                return result;
            }
            await _categoryDal.DeleteAsync(id);
            return new SuccessResult("Islem Silindi");
        }

        public async Task<IDataResult<IEnumerable<CategoryDto>>> GetAllAsync()
        {
            var result = await _categoryDal.GetListAsync(); 
            return new SuccessDataResult<IEnumerable<CategoryDto>>(_mapper.Map<IEnumerable<CategoryDto>>(result));
        }

        public async Task<IDataResult<CategoryDto>> GetByIdAsync(string id)
        {
            var result = await _categoryDal.GetByIdAsync(id);
            return new SuccessDataResult<CategoryDto>(_mapper.Map<CategoryDto>(result));
        }

        public async Task<IResult> UpdateAsync(CategoryDto category)
        {
            var categories = _mapper.Map<Category>(category);
            await _categoryDal.UpdateAsync(categories.Id,categories);
            await _publishEndpoint.Publish<CategoryNameChangedEvent>(new CategoryNameChangedEvent { CategoryId = categories.Id, UpdatedName = categories.Name });
            return new SuccessResult("Islem Basarili");
            
        }
        public  IResult CheckIfCategoryIdExists(string categoryId)
        {
            var result = _categoryDal.Any(x => x.Id == categoryId);
            if (!result)
            {
                return new ErrorResult("Boyle bir id yoktur");
            }
            return new SuccessResult();
        }
    }
}
