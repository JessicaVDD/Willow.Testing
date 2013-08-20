using System;
using System.Reflection;

namespace Willow.Testing.Core.Reflection
{
    public class PropertyInfoMemberAccessor : MemberAccessor
    {
        PropertyInfo member;

        public PropertyInfoMemberAccessor(PropertyInfo member)
        {
            this.member = member;
        }

        public Type accessor_type
        {
            get { return this.member.PropertyType; }
        }

        public Type declaring_type
        {
            get { return this.member.DeclaringType; }
        }

        public void change_value_to(object target,object new_value)
        {
            if (this.member.CanWrite) this.member.SetValue(target, new_value, null);
        }

        public string name
        {
            get { return this.member.Name;}
        }

        public object get_value(object target)
        {
            return this.member.GetValue(target, null);
        }
    }
}