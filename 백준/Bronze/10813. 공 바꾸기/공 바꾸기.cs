using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        int[] arr = new int[N + 1];

        for (int i = 1; i <= N; i++)
        {
            arr[i] = i;
        }

        for (int k = 0; k < M; k++)
        {
            string[] swapInput = Console.ReadLine().Split();
            int i = int.Parse(swapInput[0]);
            int j = int.Parse(swapInput[1]);

            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        for (int i = 1; i <= N; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}