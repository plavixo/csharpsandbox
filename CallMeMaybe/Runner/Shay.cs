namespace Runner;

internal class Shay
{
    public string Greet()
    {
        return "Good day to you!";
    }

    public List<int> PickWinners()
    {
        Random randomNumberGenerator = new Random();
        List<int> picks = new List<int>()
        {
            randomNumberGenerator.Next(100),
            randomNumberGenerator.Next(100),
            randomNumberGenerator.Next(100),
            randomNumberGenerator.Next(100),
            randomNumberGenerator.Next(100)
        };
        return picks;
    }
}