using System.ComponentModel.Design;
using System.Net.Security;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int score =int.Parse(Console.ReadLine());
            if(score >=90)
            {
                Console.WriteLine("A");
            }
            else if(score>=80 && score < 90)
            {
                Console.WriteLine("B");
            }
            else if(score >=70 && score <80)
            {
                Console.WriteLine("C");
            }
            else if(score >=60 && score < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
        
    }
}