using System.Numerics;
using System.Text;

namespace Tests
{
    internal class Encrypter
    {
        internal List<BigInteger> Encrypt(string startingMessage, PublicKey publicKey)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(startingMessage);

            int exponent = publicKey.Exponent;

            List<BigInteger> messageToExponent = new List<BigInteger>();

            foreach (byte characterAsNumber in asciiBytes) {
                
                BigInteger characterRaisedToExponent = BigInteger.Pow(characterAsNumber, exponent);

                BigInteger remainder = characterRaisedToExponent % publicKey.N;

                messageToExponent.Add(remainder);
            }

            return messageToExponent;
        }
    }
}