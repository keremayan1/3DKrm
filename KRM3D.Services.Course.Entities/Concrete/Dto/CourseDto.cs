using KRM3D.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Course.Entities.Concrete.Dto
{
    public class CourseDto:IDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CourseName { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedTime { get; set; }

        public FeatureDto Feature { get; set; }

    }
}
