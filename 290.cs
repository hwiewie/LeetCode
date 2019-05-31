using System;
using System.Text;

namespace WordPattern
{
    class WordPattern
    {
        private static bool GetDC(string pattern, string str)
        {
            char[] templates = pattern.ToCharArray();
            string[] sArray = str.Split(' ');
            char[templates.Length] temppattern;
            string[templates.Length] tempword;
            int count = 1;
            if (sArray.Count()!=templates.Length)
            {
                return false;
            }
            temppattern[0]=templates[0];
            tempword[0]=sArray[0];
            for(i=1;i<templates.Length;i++)
            {
                for(j=0;j<count;j++)
                {
                    if(temppattern[j]==templates[i])
                    {
                        if(tempword[j]!=sArray[i])
                            return false;
                        break;
                    }
                    else
                    {
                        if(tempword[j]==sArray[i])
                            return false;
                    }
                    if(j==(count-1))
                    {
                        temppattern[count]=templates[i];
                        tempword[count]=sArray[i];
                        count++;
                        break;
                    }
                }
            }
            return true;
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入Pattern(格式為一串小寫字母，每個字母代表一個單字)：");
            string template = Console.ReadLine();
            Consloe.WriteLIne("請輸入一段文字，裡面每個單字的所有字母都是小寫，單字與單字中間用空白隔開：");
            string tempstring = Console.ReadLine();
            if(GetDC(template,tempstring))
                Console.Write("True");
            else
                Console.Write("False");
        }
    }
}