using System;
using System.Reflection;

namespace Willow.Testing.Core.Reflection
{
    public class FieldMemberAccessor : MemberAccessor
    {
        FieldInfo member;

        public FieldMemberAccessor(FieldInfo member)
        {
            this.member = member;
        }

        public Type accessor_type
        {
            get { return this.member.FieldType; }
        }

        public string name
        {
            get { return this.member.Name; }
        }

        public void change_value_to(object target,object new_value)
        {
            this.member.SetValue(target, new_value);
        }

        public Type declaring_type
        {
            get { return this.member.DeclaringType;}
        }

        public object get_value(object target)
        {
            return this.member.GetValue(target);
        }
    }
}