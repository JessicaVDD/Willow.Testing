using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Willow.Testing.Dsl.FieldSwitching;

namespace Willow.Testing.Core
{
    public interface IConfigureSpecifications
    {
        void catch_exception(Action behaviour_to_trigger);
        void catch_exception<T>(Func<IEnumerable<T>> behaviour);
        ChangeExpression change(Expression<Func<object>> expression);
        Exception exception_thrown { get; }
    }
}