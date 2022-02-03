using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.DataAccess.EntityFramework.Context
{
    public class EfContextBase:DbContext
    {
        public IConfiguration Configuration { get; }

        public EfContextBase(DbContextOptions<EfContextBase>options,IConfiguration configuration):base(options)
        {
            Configuration = configuration;
        }
        public EfContextBase(DbContextOptions options,IConfiguration configuration):base(options)
        {
            Configuration = configuration;
        }
       
    }
}
