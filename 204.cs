using System;
using System.Text;

namespace Primes
{
    class CountPrimes
    {
        static private int countprimes(int a)
        {
            if(a<2)
                return 0;
            else if(a==2)
                return 1;
            else if(a==3)
                return 2;
            else if(a==4)
                return 2;
            int result=2;
            for(int i=5;i<=a;i++)
            {
                if(i%6!=1||i%6!=5)
                    continue;
                double sqrt = Math.Sqrt(i);
                int b=Convert.ToInt32(sqrt);
                bool ifaisp=true;
                for(int j=2;j<=b;j++)
                {
                    if(i%j==0)
                    {
                        ifaisp=false;
                        break;
                    }
                }
                if(ifaisp)
                    result+=1;
            }
            return result;
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一個正整數n，程式會計算小於n的質數個數：");
            string tempnum=Console.ReadLine();
            int numb=0;
            try
            {
                numb=Int32.Parse(tempnum);
            }
            catch
            {
                Console.WriteLine("輸入數字不正確！");
                Environment.Exit(0);
            }
            Console.WriteLine("共有{0}個質數",countprimes(numb));
        }
    }
}