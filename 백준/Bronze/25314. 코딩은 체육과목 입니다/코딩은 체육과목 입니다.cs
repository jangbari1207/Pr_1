using System.ComponentModel.Design;
using System.Net.Security;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int N=int.Parse(Console.ReadLine());
            int A = N/4;
            for(int i =0;i<A;i++)
            {
                Console.Write("long ");
            }
            Console.WriteLine("int");
        }
        
    }
}
