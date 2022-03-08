using KRM3D.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Course.Entities.Concrete
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string CourseName { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedTime { get; set; }
        public Feature Feature { get; set; }
    }
}
