using System;
using System.Text;

namespace ESCT
{
    class excelcolumn
    {
        private static string returnexcel(int num)
        {
            string result="";
            int tempnum=0;
            //char[] columnname = new char[]{'0','A','B'}
            do
            {
                int mod = num%26;
                if(mod==0)
                    result+='Z';
                else
                    result+=Convert.ToChar(mod+64);
                num=num/26;
            }while(num>0);
            char[] chararray = result.ToCharArray();
            Array.Reverse(chararray);
            return new string(chararray);
        }
        static void main(string[] args)
        {
            Console.WriteLine("請給一個正整數，程式會回傳在excel表格中對應的欄位：");
            string tempnum = Console.ReadLine();
            int a = Int32.Parse(tempnum);
            Console.WriteLine("結果為{0}",returnexcel(a));
        }
    }
}