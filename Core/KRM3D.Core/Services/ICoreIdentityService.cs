using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.Services
{
    public interface ICoreIdentityService
    {
         string GetUserId { get; }
    }
}
