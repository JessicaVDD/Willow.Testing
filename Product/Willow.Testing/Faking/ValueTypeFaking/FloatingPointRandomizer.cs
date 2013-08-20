using System;

namespace Willow.Testing.Faking.ValueTypeFaking
{
    public class FloatingPointRandomizer<T> : IRandomizer<T> where T : struct, IConvertible
    {
        readonly Random _Rnd;
        public FloatingPointRandomizer(Random rnd)
        {
            this._Rnd = rnd;
        }

        public T Next()
        {
            object res = null;
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Decimal:
                    res = (decimal)(this._Rnd.NextDouble() - 0.5) * 2 * decimal.MaxValue; break;
                case TypeCode.Double:
                    res = (this._Rnd.NextDouble() - 0.5) * 2 * double.MaxValue; break;
                case TypeCode.Single:
                    res = (float)(this._Rnd.NextDouble() - 0.5) * 2 * float.MaxValue; break;
            }
            return res == null ? default(T) : (T)res;
        }
    }
}