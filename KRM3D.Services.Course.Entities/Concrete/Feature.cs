using KRM3D.Core.Entities.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Course.Entities.Concrete
{


    public class Feature : IEntity
    {
        public int Duration { get; set; }
    }
}
