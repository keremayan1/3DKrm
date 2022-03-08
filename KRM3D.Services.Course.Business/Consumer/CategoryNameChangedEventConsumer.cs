using KRM3D.Core.Messages;
using KRM3D.Services.Course.DataAccess.Abstract;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Course.Business.Consumer
{
    public class CategoryNameChangedEventConsumer : IConsumer<CategoryNameChangedEvent>
    {
        ICourseDal _courseDal;

        public CategoryNameChangedEventConsumer(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public async Task Consume(ConsumeContext<CategoryNameChangedEvent> context)
        {
            var course = await _courseDal.GetAsync(x => x.CategoryId == context.Message.CategoryId);
            await _courseDal.AddAsync(course);

        }
    }
}
