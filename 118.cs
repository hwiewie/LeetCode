using System;
using System.Text;

namespace PascalsTriangle
{
    class PT
    {
        static void printpascals(int numRows)
        {
            int[,] ary = new int[numRows, numRows];
            for (int i = 0; i < numRows; i++)
            {
                //設定直邊與斜邊都是1 
                ary[i, 0] = 1;
                ary[i, i] = 1;
            }
            for (int i = 1; i < numRows; i++) //外迴圈
            {
                for (int j = 1; j <= i; j++) //內迴圈
                {
                    //內部數字要等同位置上方和左上角的和
                    ary[i, j] = ary[i - 1, j - 1] + ary[i - 1, j];
                }
            }
            for(int k=0;k<numRows;k++)
            {
                for(int l=0;l<=k;k++)
                {
                    Console.Write("[{0}]",ary[k,l]);
                }
                Console.WriteLine();
            }
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入巴斯卡三角型的列數：");
            string temp=Console.ReadLine();
            int numRows=Convert.ToInt32(temp);
            printpascals(numRows);
        }
    }
}