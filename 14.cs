using System;
using System.Text;

namespace ComPrefix
{
    class LongComPrefix
    {
        private int countcomprefix(string str)
        {
            string[] temp = str.Split(' ');
            int lens = temp[0].Length;
            
            for (int i =1;i < str.Length;i++)
            {
                if(temp[i].Length < lens)
                    lens = temp[i].Length;
            }
            for (int j =0;j<lens;j++)
            {
                char lastcom = temp[0][j];
                for(int k=0;k<str.Length;k++)
                {
                    if(lastcom!=temp[k][j])
                        return j;
                }
            }
            return lens;
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一段英文字串，程式會計算所有字串的共同字母數。");
            string temp = Console.ReadLine();
            Console.WriteLine("最多共同字母數為：%d",countcomprefix(temp));
        }
    }
}