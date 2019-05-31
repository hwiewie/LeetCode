using System;
using System.Text;

namespace POT
{
    class PowerofTwo
    {
        static private bool ifpot(string str)
        {
            int aa = Convert.ToInt32(str);
            do
            {
                if(aa%2!=0)
                    return false;
                int bb = aa / 2;
                aa = bb;
                if(aa==1)
                    return true;
            }while(aa>0);
            return true;
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一個整數，程式會判斷是否是2的次方數:");
            string tempnum = Console.ReadLine();
            if(ifpot(tempnum))
                Console.WriteLine("是2的次方數");
            else
                Console.WriteLine("不是2的次方數");
        }
    }
}