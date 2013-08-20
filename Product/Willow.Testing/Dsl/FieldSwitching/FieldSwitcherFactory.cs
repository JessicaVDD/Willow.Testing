using System.Reflection;

namespace Willow.Testing.Dsl.FieldSwitching
{
    public interface FieldSwitcherFactory
    {
        ISwapValues create_to_target(MemberInfo member);
    }
}