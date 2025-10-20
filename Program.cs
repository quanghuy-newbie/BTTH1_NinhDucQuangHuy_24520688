using System;
namespace Baitapcoban
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Nhap so luong phan tu : ");
            int n = int.Parse(Console.ReadLine());
            int[] MyArr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                MyArr[i] = rnd.Next();
                Console.WriteLine(MyArr[i]+" ");
            }
            Console.WriteLine(" Tong cac so le: "+TinhTong(n, MyArr));
            Console.WriteLine(" So luong so Nguyen To : " + Countprime(MyArr));


            Console.ReadKey();
        }
        static long TinhTong(int a,int[] MyArr)
        {
            long sum =0;
            for(int i = 0;i < a;i++)
            {
                if(MyArr[i]%2!=0 )
                {
                    sum += MyArr[i];
                }    
            }
            return sum;
        }
        static bool isprime(int a)
        {
            for(int i = 2; i < Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
                
        }
        static int Countprime( int[] MyArr)
        {
            int count = 0;
            for(int  i = 0; i < MyArr.Length;i++)
            {
                if(isprime(MyArr[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}