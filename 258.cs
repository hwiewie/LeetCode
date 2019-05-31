using System;
using System.Text;

namespace AddDigits
{
    class numberadd
    {
        static private string charadd(string str)
        {
            char[] temp = str.ToCharArray();
            int numb =0;
            for(int i=0;i<str.Length;i++)
            {
                numb += Int32.Parse(temp[i]);
            }
            string result = numb.ToString();
            if(result.Length>1)
                charadd(result);
            else
            {
                return numb;
            }
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一個數字，程式會計算該數字的所有位數相加");
            string number1 = Console.ReadLine();
            if(number1.Length>1)
                Console.WriteLine("結果為%d",charadd(number1));
            else
                Console.WriteLine("結果為%s",number1);
        }
    }
}