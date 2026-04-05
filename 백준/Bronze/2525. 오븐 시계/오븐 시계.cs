using System.ComponentModel.Design;
using System.Net.Security;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[]arr=Array.ConvertAll(Console.ReadLine().Split(),int.Parse);//현재 시와 분 입력
            int A=arr[0];
            int B=arr[1];
            int C =int.Parse(Console.ReadLine());//요리시간
           B+=C;//현재 분에 요리 시간 더하기
        if(B>=60)//분이 60분이상?
        {
          A+= B/60; //60으로 나눈 몫 만큼 시간 더하기
            B %= 60; //60으로 나눈 나머지가 새로운 분이 됨
        }
            if(A>=24) //시간이 24시이상?
            {
                A %= 24; //24로 나눈 나머지로 시간 설정(예 : 25시 -> 1시)
            }
            Console.WriteLine($"{A} {B}");
        
        
            
        
        }
    }
}
