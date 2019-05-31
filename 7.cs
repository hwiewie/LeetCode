using System;
using System.Text;

namespace ReverseInt
{
    class ReverseInt
    {
        private static int returnrevint(int num)
        {
            int mul=1;
        	if(num<0)
        	{
                mul=-1;
                num*=-1;
        	}
            int high =0,low=0,i=Convert.ToInt32(Math.Log10(num)),res=0;
            do
            {
                low=num%10;
                if(res+low*Math.Pow(10,i)>2147483647)
                    return 0;
                res=low*(Convert.ToInt32(Math.Pow(10,i)));
                num/=10;
                i--;
            }while(i>0);
            res+=num;
            res*=mul;
            return res;
        }
        public static void main(string[] args)
        {
            Console.WriteLine("請輸入一個整數，程式會將數字反轉：");
            string tempnum = Console.ReadLine();
            try
            {
                int numb = Int32.Parse(tempnum);
                Console.WriteLine("結果為：{0}",returnrevint(numb));
            }
            catch
            {
                Console.WriteLine("結果為：0");
            }
        }
    }
}