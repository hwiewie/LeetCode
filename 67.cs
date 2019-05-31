using System;
using System.Text;

namespace AddBinary
{
    class binarystring
    {
        private string addstring(string str1,string str2)
        {
            char[] char1 = str1.ToCharArray();
            char[] char2 = str2.ToCharArray();
            char[] result;
            char char0 = '0';
            int numb = 0; 

            for(int i = str1.Length-1;i>=0;i--)
            {
                if(i<str2.Length)
                {
                    if(char1[i]=='0')
                    {
                        if(char2[i]=='0')
                        {
                            if(char0=='0')
                            {
                                result[numb]='0';
                            }
                            else
                            {
                                result[numb]='1';
                                char0='0';
                            }
                        }
                        else
                        {
                            if(char0=='0')
                            {
                                result[numb]='1';
                            }
                            else
                            {
                                result[numb]='0';
                                char0='1';
                            }
                        }
                    }
                    else
                    {
                        if(char2[i]=='0')
                        {
                            if(char0=='0')
                            {
                                result[numb]='1';
                            }
                            else
                            {
                                result[numb]='0';
                                //char0='1';
                            }
                        }
                        else
                        {
                            if(char0=='0')
                            {
                                result[numb]='0';
                                char0='1';
                            }
                            else
                            {
                                result[numb]='1';
                                //char0='1';
                            }
                        }
                    }
                }
                if(char1[i]=='0')
                {
                    if(char0=='0')
                    {
                        result[numb]='0';
                    }
                    else
                    {
                        result[numb]='1';
                        char0='0';
                    }
                }
                else
                {
                    if(char0=='0')
                    {
                        result[numb]='1';
                    }
                    else
                    {
                        result[numb]='0';
                        char0='1';
                    }
                }
                numb+=1;
            }
            string reverse;
            for(int j = numb-1;j >=0;j--)
            {
                reverse+=result[j];
            }
            return reverse;
        }
        static void main(string[] args)
        {
            Console.WriteLine("程式會相加2個字串，用binary的方式");
            Console.WriteLine("請輸入第1個字串(字串以1或0組成)：");
            string temp1 = Console.ReadLine();
            Console.WriteLine("請輸入第2個字串(字串以1或0組成)：");
            string temp2 = Console.ReadLine();
            if(temp1.Length>temp2.Length)
                Console.WriteLine("%s",addstring(temp1,temp2));
            else
                Console.WriteLine("%s",addstring(temp2,temp1));
        }
    }
}