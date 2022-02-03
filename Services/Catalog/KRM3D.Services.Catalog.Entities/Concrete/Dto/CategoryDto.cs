using KRM3D.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Catalog.Entities.Concrete.Dto
{
    public class CategoryDto:IDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
