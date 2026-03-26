using System;
using System.Text;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < t; i++)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            sb.AppendLine((a + b).ToString());
        }

        Console.Write(sb.ToString());
    }
}