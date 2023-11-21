class Program
{
    static void Main(string[] args)
    {
        int[] test = { 1, 2, 3, 4, 5 };

        test = test.Skip(1).ToArray();
        
        Array.Resize(ref test, test.Length - 1);

        foreach (int i in test)
        {
            Console.WriteLine(i);
        }

    }
}