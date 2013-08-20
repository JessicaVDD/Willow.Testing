using Machine.Specifications;

namespace Willow.Testing.Extensions
{
    public static class AssertionExtensions
    {
        public static T ShouldBeAn<T>(this object result)
        {
            result.ShouldBe(typeof(T));
            return (T) result;
        }
    }
}