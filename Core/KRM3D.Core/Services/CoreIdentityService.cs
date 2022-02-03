using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.Services
{
    public class CoreIdentityService : ICoreIdentityService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CoreIdentityService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserId =>
            _httpContextAccessor.HttpContext.User.FindFirst("sub").Value;
    }
}
