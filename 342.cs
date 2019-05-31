using System;
using System.Text;

namespace POF
{
    class poweroffour
    {
        private static bool iffour(string str)
        {
            int numb=Convert.ToInt32(str);
            do{
                if(numb<4)
                    return false;
                if(numb%4==0)
                {
                    numb=numb/4;
                }
                else
                    return false;
                if(numb==1)
                {
                    return true;
                }
            }while(numb>3);
        }
        public static void main(string[] args)
        {
            Console.WriteLine("請輸入一個數，程式會判斷此數是否為4的次方數");
            string tempnum = Console.ReadLine();
            if(iffour(tempnum))
                Console.WriteLine("此數為4的次方數");
            else
                Console.WriteLine("此數不是4的次方數");
        }
    }
}