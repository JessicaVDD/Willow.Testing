using System;

namespace Willow.Testing.Faking.ValueTypeFaking
{
    public class GeneralRandomizer<T> : IRandomizer<T> where T : struct, IConvertible
    {
        readonly Random _Rnd;
        public GeneralRandomizer(Random rnd)
        {
            this._Rnd = rnd;
        }

        public T Next()
        {
            var bytes = BitConverter.GetBytes(0UL);
            this._Rnd.NextBytes(bytes);
            var lng = BitConverter.ToUInt64(bytes, 0);

            return (T) ((IConvertible) lng).ToType(typeof (T), null);
        }
    }
}