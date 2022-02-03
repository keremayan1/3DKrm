
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using KRM3D.Core.DataAccess.MongoDb.Context;
using KRM3D.Core.Utilities.Interceptors;
using KRM3D.Services.Catalog.Business.Abstract;
using KRM3D.Services.Catalog.Business.Concrete;
using KRM3D.Services.Catalog.DataAccess.Abstract;
using KRM3D.Services.Catalog.DataAccess.Concrete.MongoDb;
using KRM3D.Services.Catalog.DataAccess.Concrete.MongoDb.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;
namespace KRM3D.Services.Catalog.Business.DependencyResolvers.Autofac
{
    public  class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MongoDbContext>().As<MongoDbContextBase>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<MongoDbCategoryDal>().As<ICatagoryDal>().InstancePerLifetimeScope();


            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }
    }
}
