using System;
using System.Text;
using static System.Math;

namespace ExcelSheet
{
    class columnnumber
    {
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一串Excel上欄位的號碼:");
            string tempnum = Console.ReadLine();
            char[] charnum = tempnum.ToCharArray();
            double numb = 0;
            for(int i=tempnum.Length -1;i >= 0;i--)
            {
                numb += (Convert.ToInt32(char.ToLower(charnum[i]))-96)*Math.Pow(26,i);
            }
            Console.WriteLine("{0}",numb);
        }
    }
}