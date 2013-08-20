using Willow.Testing.Core.Reflection;

namespace Willow.Testing.Dsl.FieldSwitching
{
public class MemberTargetValueSwapper : ISwapValues
{
    MemberAccessor member_accessor;
    object original_value;

    public MemberTargetValueSwapper(MemberAccessor member_accessor)
    {
        this.member_accessor = member_accessor;
        this.original_value = member_accessor.get_value(member_accessor.declaring_type);
    }

    public ObservationPair to(object new_value)
    {
        return new ObservationPair(() => this.member_accessor.change_value_to(this.member_accessor.declaring_type,new_value),
            () => this.member_accessor.change_value_to(this.member_accessor.declaring_type,this.original_value));
    }
}
 
 
}