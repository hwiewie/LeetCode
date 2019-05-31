using System;
using System.Text;

namespace ComVerNum
{
    class compvers
    {
        static int compareversion(string ver1,string ver2)
        {
            string[] version1 = ver1.Split('.');
            string[] version2 = ver2.Split('.');
            int minarray = 0;
            bool verequ = false;
            if(version1.Length > version2.Length)
            {
                minarray = version2.Length;
            }
            else if(version1.Length < version2.Length)
            {
                minarray = version1.Length;
            }
            else
            {
                minarray = version1.Length;
                verequ = true;
            }
            for(int i = 0;i < minarray;i++)
            {
                if(version1[i]==version2[i])
                    continue;
                if(string.ToLower(version1[i])>string.ToLower(version2[i]))
                    return 1;
                else
                    return -1;
            }
            if(verequ)
                return 0;
            if(version1.Length > version2.Length)
                return 1;
            else
                return -1;
        }
        static void main(string[] args)
        {
            Console.WriteLine("程式會比較2個版本號，如果第一個版本號比較大就回傳1，比較小就回傳-1，二個版本號相等就回傳0");
            Console.WriteLine("請輸入第一個版本號，子版本號用.分隔:");
            string version1 = Console.ReadLine();
            Console.WriteLine("請輸入第二個版本號:");
            string version2 = Console.ReadLine();
            Console.WriteLine("結果為：%d",compareversion(version1,version2));
        }
    }
}