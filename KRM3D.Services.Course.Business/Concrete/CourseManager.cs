using AutoMapper;
using KRM3D.Core.Utilities.Results;
using KRM3D.Services.Course.Business.Abstract;
using KRM3D.Services.Course.DataAccess.Abstract;
using KRM3D.Services.Course.Entities.Concrete.Dto;

namespace KRM3D.Services.Course.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;
        private readonly IMapper _mapper;

        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(Entities.Concrete.Course course)
        {
           //var courses = _mapper.Map<Entities.Concrete.Course>(course);
         
           // courses.CreatedTime=DateTime.Now;
            await _courseDal.AddAsync(course); 
            
            return new SuccessResult();
        }

        public async Task<IDataResult<List<Entities.Concrete.Course>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Entities.Concrete.Course>>(await _courseDal.GetAllAsync());
        }

        public async Task<IDataResult<List<CourseDto>>> GetAllAsync2()
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdateAsync(Entities.Concrete.Course course)
        {
            await _courseDal.UpdateAsync(course);
            return new SuccessResult();
        }
    }
}
