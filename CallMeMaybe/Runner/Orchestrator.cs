namespace Runner;

internal class Orchestrator
{
    public void Go()
    {
        
        /*
         * Buying a lottery ticket can be a very superstitious thing.
         * People generally like to pick their own numbers.
         * Here are a couple of people with strong views on how they choose their number - go check their methods.
         */

        Amanda amanda = new Amanda();
        Dorothy dorothy = new Dorothy();
        Shay shay = new Shay();
        


        /*
         * Notice that every person has a method for getting lottery numbers.
         * The methods have different names, but they all have the same signature. They all:
         *     * take no parameters
         *     * return a List<int>
         * That's important: regardless of the name of the method, it has the same signature.
         *
         * This is where a bit of delegate-magic comes in. Go look at the delegate in WayOfDeterminingNumbers.cs
         */

        //----

        /*
         * There are services that match people with assistants willing to do jobs.
         * Let's make an assistant that has a method that tells it to buy a lottery ticket.
         */
        
        Assistant assistant = new Assistant();
        

        /*
         * Let's ask our assistant to buy a lottery ticket for each person.
         * but we want them to CALLBACK to the person when it comes to choosing the numbers.
         * We'll ask them to get the ticket, and we'll give them a reference to the person to call.
         * Specifically, everyone has their own method of choosing lottery numbers (a method with no arguments and a List<int> return type)
         * so we'll give the assistant a reference to that specific method to call
         * - that person's method for how they determine their lottery numbers.    
         */

        Console.WriteLine($"Let's buy a ticket for Amanda");
        assistant.GoBuyLotteryTicket(amanda.ChooseNumbers);


        Console.WriteLine($"Now,let's buy a ticket for Dorothy");
        assistant.GoBuyLotteryTicket(dorothy.DecideDigits);

        Console.WriteLine($"Finally, buy a ticket for Shay");
        assistant.GoBuyLotteryTicket(shay.PickWinners);

    }
}