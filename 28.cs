using System;
using System.Text;

namespace strstr
{
    class implementstr
    {
        private int strlocation(string str1,string str2)
        {
            char[] text1 = str1.ToCharArray();
            char[] pattern = str2.ToCharArray();
            int patlen = str2.Length;
            int framelen = str1.Length - patlen;
            bool ifmatch=false;
            for(int i=0;i<framelen;i++)
            {
                if(ifmatch)
                {
                    return i+1;
                }
                if(text1[i]==pattern[0])
                {
                    for(j=1;j<patlen;j++)
                    {
                        if(text1[i+j]==pattern[j])
                            ifmatch=true;
                        else
                        {
                            ifmatch=false;
                            break;
                        }
                    }
                }
            }
            if(ifmatch)
                return i;
            else
                return 0;
        }
        static void main(string[] args)
        {
            Console.WriteLine("程式會比對2個字串，");
            Console.WriteLine("請輸入字串：");
            string temp1 = Console.ReadLine();
            Console.WriteLine("請輸入要找字串中的pattern：");
            string temp2 = Console.ReadLine();
            int numb = 0;
            if(temp1.Length > temp2.Length)
            {
                numb=strlocation(tepm1,temp2);
            }
            else
                numb=strlocation(temp2,temp1);
            Console.WriteLine("Pattern第一次出現在字串的第%d個字母",numb);
        }
    }
}