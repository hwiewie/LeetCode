using System;
using System.Text;

namespace POT
{
    class PowerofTree
    {
        static private bool ifpot(string str)
        {
            int aa = Convert.ToInt32(str);
            do
            {
                if(aa%3!=0)
                    return false;
                int bb = aa / 3;
                aa = bb;
                if(aa==1)
                    return true;
            }while(aa>0);
            return true;
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一個整數，程式會判斷是否是3的次方數:");
            string tempnum = Console.ReadLine();
            if(ifpot(tempnum))
                Console.WriteLine("是3的次方數");
            else
                Console.WriteLine("不是3的次方數");
        }
    }
}