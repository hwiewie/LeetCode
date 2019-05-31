using System;
using System.Text;

namespace LastWord
{
    class LenLastWord
    {
        private static int lenofword(string str)
        {
            string[] words = str.Split(' ');
            int count = str.Length-1;
            do
            {
                if(words[count]!=' ')
                {
                    return words[count].Length;
                }
            }while(count>0);
            return 0;
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一段英文，程式會計算最後一個單字的字母數。");
            string temp = Console.ReadLine();
            int numb = lenofword(temp);
            Console.WriteLine("最後一個單字長度為：%d",numb);
        }
    }
}