namespace Runner;

internal class Dorothy
{
    private int _luckyNumber = 17;

    public string Greet()
    {
        return "Hi!!!!";
    }
    
    public List<int> DecideDigits()
    {
        List<int> numbers = new List<int>();

        numbers.Add(DateTime.Now.Second);
        numbers.Add(DateTime.Now.Day * DateTime.Now.Hour);
        numbers.Add(_luckyNumber);
        numbers.Add("Fido".Length);
        numbers.Add(System.Environment.ProcessorCount);

        return numbers;
    }

 
}