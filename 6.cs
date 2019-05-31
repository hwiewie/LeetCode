using System;
using System.Text;

namespace ZigZag
{
    class ZigZagConv
    {
        private string convtozigzag(string line,int lines)
        {
            char[] temp = line.ToCharArray();
            char[] res;
            int mode=lines*2-2;
            for(int i =0;i < lines;i++)
            {
                int y = i+1 - (x * mode);
            }
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一段字串：");
            string templine = Console.ReadLine();
            Console.WriteLine("請輸入要將字串轉成幾行：");
            int lines = Console.ReadLine();

        }
    }
}