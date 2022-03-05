using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using KRM3D.Core.Utilities.Interceptors;
using KRM3D.Services.Course.Business.Abstract;
using KRM3D.Services.Course.Business.Concrete;
using KRM3D.Services.Course.DataAccess.Abstract;
using KRM3D.Services.Course.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace KRM3D.Services.Course.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<CourseManager>().As<ICourseService>().InstancePerLifetimeScope();
            builder.RegisterType<EfCourseDal>().As<ICourseDal>().InstancePerLifetimeScope();

            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }
    }
}
