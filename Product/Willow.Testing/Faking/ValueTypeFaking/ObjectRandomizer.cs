using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Willow.Testing.Faking.ValueTypeFaking
{
    public class ObjectRandomizer<T> : IRandomizer<T>
        where T : class
    {
        Func<T> _Creator;

        public ObjectRandomizer(Func<T> creator)
        {
            _Creator = creator;
        }

        public T Next()
        {
            if (ReferenceEquals(_Creator, null))
                return Activator.CreateInstance<T>();

            return _Creator();
        }
    }
}
