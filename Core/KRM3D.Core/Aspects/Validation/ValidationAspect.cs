using Castle.DynamicProxy;
using FluentValidation;
using KRM3D.Core.CrossCuttingConcerns.Validation;
using KRM3D.Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Core.Aspects.Validation
{
    public class ValidationAspect:MethodInterception
    {
        Type _type;

        public ValidationAspect(Type type)
        {
            if (!typeof(IValidator).IsAssignableFrom(type))
            {
                throw new Exception("Method yok");
            }
            _type = type;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validate =(IValidator)Activator.CreateInstance(_type);
            var entityType = _type.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(p => p.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validate, entity);
            }
        }
    }
}
