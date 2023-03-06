namespace Tests
{
    internal class PublicKey
    {
        public int N { get; }
        public int Exponent { get; }

        public PublicKey(int n, int exponent)
        {
            N = n;
            Exponent = exponent;
        }

    }
}