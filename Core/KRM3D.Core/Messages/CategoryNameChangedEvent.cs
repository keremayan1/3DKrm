using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.Messages
{
    public class CategoryNameChangedEvent
    {
        public string CategoryId { get; set; }
        public string UpdatedName { get; set; }
    }
}
