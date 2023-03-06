namespace Tests
{
    internal class ExponentGenerator
    {

        public int Exponent { get; internal set; }

        public ExponentGenerator(int prime1p, int prime2q)
        {
            Exponent = CalculateOptionsForE(prime1p, prime2q);
        }


        private int CalculateOptionsForE(int prime1p, int prime2q)
        {
            int starting1 = prime1p - 1;
            int starting2 = prime2q - 1;

            int product = starting1 * starting2;

            IEnumerable<int> primesOfProduct = GeneratePrimeFactorsFor(product);

            //e must not share any prime factors with product

            Random randomNumberGenerator = new Random();
           
            int e;
            bool eSharesPrimeFactorsWithProduct;
            
            do
            {
                e = randomNumberGenerator.Next(product);
                eSharesPrimeFactorsWithProduct = IsFactor(e, primesOfProduct);

            } while (eSharesPrimeFactorsWithProduct);

            return 7;
        }

        private bool IsFactor(int e, IEnumerable<int> factors)
        {
            bool factorInList = false;

            foreach (int factor in factors) {
                if (e % factor == 0) {
                    factorInList = true;
                    break;
                }
            }
            
            return factorInList;

        }

        private IEnumerable<int> GeneratePrimeFactorsFor(int number)
        {
            // credit to https://stackoverflow.com/a/35057874
            var primes = new List<int>();

            for (int div = 2; div <= number; div++)
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }

            IEnumerable<int> uniquePrimes = primes.Distinct();
            return uniquePrimes;
        }
    }
}