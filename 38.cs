using System;
using System.Text;

namespace ReadNumber
{
    class ReadNumber
    {
        private static string numread(string bfread)
        {
            string result = "";
            char[] numchar = bfread.ToCharArray();
            char temp = numchar[0];
            int count = 1;
            for (int i = 1; i < numchar.Length; i++)
            {
                if(temp==numchar[i])
                {
                    count+=1;
                    continue;
                }
                else
                {
                    result+=count.ToString();
                    result+=temp;
                    temp=numchar[i];
                    count=1;
                }
            }
            result+=count.ToString();
            result+=temp;
            return result;
        }
        static void main(string[] args)
        {
            //Console.WriteLine("請輸入數字");
            //string numstr = Console.ReadLine();
            string numstr = "1";
            string countnsay = numstr;
            string nextnum = numstr;
            for(int a=1;a < 10;a++)
            {
                nextnum = numread(nextnum);
                countnsay=countnsay+","+nextnum;
            }
            Console.WriteLine(countnsay);
        }
    }
}