using System;

class MatrixSwapper
{
    static void Main()
    {
        string s = "asrgset";

        char[] c = s.ToCharArray();
        Array.Sort(c);

        Console.WriteLine(c);
    }
}
