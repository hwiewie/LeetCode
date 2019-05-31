using System;
using System.Text;

namespace ContainsDuplicate
{
    class CD
    {
        private static bool ifdup(string[] temp)
        {
            for(int i=0;i<temp.Length;i++)
            {
                for(int j=i+1;j<temp.Length;j++)
                {
                    if(temp[i]==temp[j])
                        return true;
                }
            }
            return false;
        }
        static void main(string[] args)
        {
            Console.WriteLine("給一個陣列，確認陣列中是否有重複的元素");
            string[] temp={"1","2","3","4","5","6","7","8","9","0","1"};
            if(ifdup(temp))
                Console.WriteLine("有重複");
            else
                Console.WriteLine("沒有重複");
        }
    }
}