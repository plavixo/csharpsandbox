using FluentAssertions;
using Newtonsoft.Json.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Let's do the maths for Amanda's public and private keys
            int prime1p = 11;
            int prime2q = 17;
           
            int exponent = new ExponentGenerator(prime1p, prime2q).Exponent;
            
            int n = prime1p * prime2q;


            // The private key gets the raw prime1p and prime2q values
            PrivateKey privateKey = new PrivateKey(prime1p, prime2q, exponent);

            // Publishing the Public Key
            // The public key gets the product of prime1p and prime2q, but not the individual values!
            PublicKey publicKey = new PublicKey(n, exponent); 


            // I would like to send Amanda a message that only she can decrypt
            // I will encrypt it with Amanda's public key
            List<BigInteger> encryptedMessage =  new Encrypter()
                .Encrypt("The owl hoots in the moonlight", publicKey);


            // Amanda gets the message, let's decrypt it
            Decrypter decrypter = new Decrypter();

            string message = decrypter.Decrypt(encryptedMessage, privateKey);
            
            //Assert
            message.Should().Be("The owl hoots in the moonlight");
        }       
    }
}