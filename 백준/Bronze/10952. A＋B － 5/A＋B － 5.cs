using System.ComponentModel.Design;
using System.Net.Security;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
         while(true)
         {   
             int[]arr=Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                 int A=arr[0];
                 int B=arr[1];
             
             if(A ==0 && B ==0)
             {
                 break;
             }
             Console.WriteLine(A+B);
         }
        }
        
    }
}