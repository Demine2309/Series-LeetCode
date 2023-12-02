using System;

class MatrixSwapper
{
    static void Main()
    {
        string[] strings = { "eat", "tea", "tan", "ate", "nat", "bat" };

        Test(strings);
    }

    static void Test(string[] strs)
    {
        IList<string> group = new List<string>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] c = strs[i].ToCharArray();

            Array.Sort(c);

            strs[i] = new string(c);

            group.Add(strs[i]);
        }

        for (int i = 0; i < group.Count; i++)
        {
            Console.WriteLine(group[i]);
        }
    }
}
