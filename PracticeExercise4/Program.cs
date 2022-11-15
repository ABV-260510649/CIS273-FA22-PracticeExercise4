namespace PracticeExercise4;
class Program
{
    static void Main(string[] args)
    {
        var ht = new HashTableLinearProbing<string, int>();

        ht.Add("XBX", 1);
        ht.Add("XCD", 2);
        ht.Add("EP", 3);
        ht.Add("ON", 4);
        ht.Add("PKA", 5);

        Console.WriteLine( (ht.Count, 5));
        Console.WriteLine( (ht.Get("XBX"), 1));

        ht.Remove("XBX");

        Console.WriteLine( (ht.Count, 4));
        Console.WriteLine( (ht.ContainsKey("XBX")));
    }
}

