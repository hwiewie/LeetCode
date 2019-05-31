using System;
using System.Text;

namespace HN
{
    class happynumber
    {
        static bool ifhappynum(string str)
        {
            int[] looktable = new int[] { 0, 1, 4, 9, 16, 25, 36, 49 , 64, 81 };
            int[] result = new int[50];
            int count=0;
            while(true)
            {
                char[] tempnum = str.ToCharArray();
                int numb=0;
                for(int i =0;i<str.Length;i++)
                {
                    numb += looktable[Convert.ToInt32(tempnum[i])];
                }
                result[count]=numb;
                for(int j=0;j<count;j++)
                {
                    if(result[j]==numb)
                        return false;
                }
                count++;
                if(numb==1)
                    return true;
                str = numb.ToString();
            }
        }
        public static void main(string[] args)
        {
            Console.WriteLine("請輸入一個數，程式會判斷是否為Happy number：");
            string numstr = Console.ReadLine();
            if(ifhappynum(numstr))
                Console.WriteLine("此數為快樂數");
            else
                Console.WriteLine("此數不是快樂數");
        }
    }
}