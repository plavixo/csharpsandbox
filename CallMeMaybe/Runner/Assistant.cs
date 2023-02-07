namespace Runner;

internal class Assistant
{
    public void GoBuyLotteryTicket(WayOfDeterminingLotteryNumbers chooseLotteryNumbers)
    {
        Console.WriteLine("leave the house");
        Console.WriteLine("go to the shop");
        Console.WriteLine("queue up");
        Console.WriteLine("I'd like a ticket please - let me call my client and find out what numbers they want.");
        
        // run the method that you were given in order to CALLBACK to the person that sent you
        List<int> numbers = chooseLotteryNumbers();
        
        Console.WriteLine($"Let's go with numbers: {string.Join(", ", numbers)}.");
        Console.WriteLine("Thanks!");
        Console.WriteLine(Environment.NewLine);
    }
}