using System;
using System.Text;

namespace Factorial
{
    class FTZ
    {
        private static double returnzero(double numb)
        {
            double fivezero = 0;
            fivezero = numb/5;
            double tempfive = fivezero;
            double addzero = 0;
            do
            {
                if(tempfive>4)
                {
                    tempfive=tempfive/5;
                    addzero+=tempfive;
                }
            }while(tempfive>4);
            return fivezero+addzero;
        }
        public static void main(string[] args)
        {
            Console.WriteLine("請輸入一個正整數，程式會計算此正整數的階乘共有幾個0：");
            string numbs = Console.ReadLine();
            double numb = double.Parse(numbs);
            Console.WriteLine("共有{0}個0",returnzero(numb));
        }
    }
}