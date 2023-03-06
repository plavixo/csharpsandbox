using System.Numerics;
using System.Text;

namespace Tests
{
    internal class Decrypter
    {
        internal string Decrypt(List<BigInteger> encryptedMessage, PrivateKey privateKey)
        {
            int d = privateKey.D;
            BigInteger n = privateKey.N;


            StringBuilder sb = new StringBuilder();

            foreach (BigInteger inte in encryptedMessage) {
                BigInteger result = BigInteger.Pow(inte, d) % n;
                int r = (int)result;

                sb.Append((char)r);
            }


            return sb.ToString();
        }
    }
}