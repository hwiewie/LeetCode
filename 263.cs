using System;
using System.Text;

namespace Ugly
{
    class uglynum
    {
        static private bool ifugly(string str)
        {
            int numb = Convert.ToInt32(str);
            do
            {
                if(numb<2)
                    break;
                if(numb%2==0)
                {
                    numb=numb/2;
                }
                else
                    break;
            }while(numb>2);
            do
            {
                if(numb<3)
                    break;
                if(numb%3==0)
                {
                    numb=numb/3;
                }
                else
                    break;
            }while(numb>3);
            do
            {
                if(numb<5)
                    break;
                if(numb%5==0)
                {
                    numb=numb/5;
                }
                else
                    break;
            }while(numb>5);
            if(numb==1)
                return true;
            else
                return false;
        }
        static void main(tring[] args)
        {
            Console.WriteLine("請輸入數字，程式會判斷是否為Ugly number:");
            string tempnum = Console.ReadLine();
            if(ifugly(tempnum))
                Console.WriteLine("此數為Ugly number");
            else
                Console.WriteLine("此數不是Ugly number");
        }
    }
}