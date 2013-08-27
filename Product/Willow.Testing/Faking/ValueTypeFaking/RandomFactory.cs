using System;

namespace Willow.Testing.Faking.ValueTypeFaking
{
    public class RandomFactory
    {
        static readonly Random _Rnd = new Random(unchecked((int)DateTime.Now.Ticks));

        public static IRandomizer<T> GetRandomizer<T>() where T : struct, IConvertible
        {
            IRandomizer<T> res = null;
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Boolean:
                case TypeCode.Byte:
                case TypeCode.Char:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.DateTime:
                    res = new IntegralRandomizer<T>(_Rnd); break;
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    res = new FloatingPointRandomizer<T>(_Rnd); break;
                case TypeCode.DBNull:
                case TypeCode.String:
                case TypeCode.Empty:
                case TypeCode.Object:
                    res = new GeneralRandomizer<T>(_Rnd); break;
            }

            if (ReferenceEquals(res, null)) throw new ArgumentException("Cannot create a generator for the specified type.");
            return res;
        }

        public static IRandomizer<T> GetRandomizer<T>(Func<T> creator) where T : class
        {
            return new ObjectRandomizer<T>(creator);
        }

    }
}