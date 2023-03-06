using System.Numerics;

namespace Tests
{
    internal class PrivateKey
    {
        public int D { get; internal set; }
        public BigInteger N { get; internal set; }


        public PrivateKey( int prime1p, int prime2q, int exponent)
        {
            N = prime1p * prime2q;


            int thing = (prime1p - 1) * (prime2q - 1) + 1;
            int thing2 = thing / exponent;

            D = thing2;
        }

    }
}