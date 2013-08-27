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

        public static T a_sealed<T>(this ICreateFakes fake, Func<T> creator) where T : class
        {
            var rnd = RandomFactory.GetRandomizer<T>(creator);
            return rnd.Next();
        }
    }
}