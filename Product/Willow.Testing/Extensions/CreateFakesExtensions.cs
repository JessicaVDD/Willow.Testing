using System;
using Willow.Testing.Core;
using Willow.Testing.Faking.ValueTypeFaking;

namespace Willow.Testing.Extensions
{
    public static class CreateFakesExtensions
    {
        public static T a_value<T> (this ICreateFakes fake) where T : struct, IConvertible
        {
            var rnd = RandomFactory.GetRandomizer<T>();
            return rnd.Next();
        }
    }
}