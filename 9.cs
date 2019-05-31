using System;
using System.Text;

namespace Palindrome
{
    class PN
    {
        private static bool ifpalindrome(int num)
        {
            if(num < 0)
                return false;
            int high =0,low=0,i=Convert.ToInt32(Math.Log10(num));
            do
            {
                high=num/Convert.ToInt32(Math.Pow(10,i));
                low=num%10;
                if(high!=low)
                    return false;
                num-=high*(Convert.ToInt32(Math.Pow(10,i)));
                num/=10;
                i-=2;
            }while(i>0);
            return true;
        }
        public static void main(string[] args)
        {
            Console.WriteLine("請輸入一個整數，程式會判斷是否為迴文數字：");
            string tempnum = Console.ReadLine();
            int numb = Int32.Parse(tempnum);
            if(ifpalindrome(numb))
                Console.WriteLine("是迴文");
            else
                Console.WriteLine("不是迴文");
        }
    }
}