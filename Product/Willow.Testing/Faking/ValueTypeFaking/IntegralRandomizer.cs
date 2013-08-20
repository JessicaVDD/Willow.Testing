using System;

namespace Willow.Testing.Faking.ValueTypeFaking
{
    public class IntegralRandomizer<T> : IRandomizer<T> where T : struct, IConvertible
    {
        readonly Random _Rnd;

        public IntegralRandomizer(Random rnd)
        {
            this._Rnd = rnd;
        }

        public T Next()
        {
            object res = null;
            var bytes = BitConverter.GetBytes(0UL);
            this._Rnd.NextBytes(bytes);
            var lng = BitConverter.ToUInt64(bytes, 0);

            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Boolean:
                    res = (lng%2 == 0); break;
                case TypeCode.Byte:
                    res = (byte)lng; break;
                case TypeCode.Char:
                    res = (char)lng; break;
                case TypeCode.Int16:
                    res = (short)lng; break;
                case TypeCode.Int32:
                    res = (int)lng; break;
                case TypeCode.Int64:
                    res = (long)lng; break;
                case TypeCode.SByte:
                    res = (sbyte)lng; break;
                case TypeCode.UInt16:
                    res = (ushort)lng; break;
                case TypeCode.UInt32:
                    res = (uint)lng; break;
                case TypeCode.UInt64:
                    res = lng; break;
                case TypeCode.DateTime:
                    res = new DateTime(Math.Abs((long)lng)); break;
            }

            return res == null ? default(T) : (T) res;
        }
    }
}