using System;
using System.Text;

namespace Parentheses
{
    class ValidParentheses
    {
        private static bool pairs(string str)
        {
            bool result = true;
            char[] temp = str.ToCharArray();
            char[] pars;
            int num = -1;
            for(int i =0;i < str.Length;i++)
            {
                switch(temp[i])
                {
                    case '{':
                    case '[':
                    case '(':
                        num+=1;
                        pars[num]=temp[i];
                        break;
                    case ')':
                        if(pars[num]=='(')
                        {
                            num-=1;
                            break;
                        }
                        else
                        {
                            result=false;
                            return result;
                        }
                    case ']':
                        if(pars[num]=='[')
                        {
                            num-=1;
                            break;
                        }
                        else
                        {
                            result=false;
                            return result;
                        }
                    case '}':
                        if(pars[num]=='{')
                        {
                            num-=1;
                            break;
                        }
                        else
                        {
                            result=false;
                            return result;
                        }
                }
            }
            return result;
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一段包含()、[]、{}等括號的字串，程式會判斷是否有不成對的括號。");
            string template = Console.ReadLine();
            if(pairs(template))
                Console.WriteLine("字串內括號有合法！");
            else
                Console.WriteLine("字串內的括號沒有成對，不合法！");
        }
    }
}