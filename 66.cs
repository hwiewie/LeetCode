using System;
using System.Text;

namespace PlusOne
{
    class PO
    {
        static private int[] arrayadd(int[] array1)
        {
            int leng = array1.Length;
            int comma = 0;
            for(int i=leng-1;i>=0;i--)
            {
                if(i==leng-1)
                    array1[i]+=1;
                if(comma==1)
                {
                    array1[i]+=comma;
                    comma=0;
                }
                if(array1[i]==10)
                {
                    array1[i]=0;
                    comma = 1;
                }
            }
            return array1;
        }
        public static void main(string[] args)
        {
            int[] array1 = new int[] {1,3,5,7,9};
            int[] array2 = arrayadd(array1);
            string result="";
            int ar2len=array2.Length;
            for(int i=0;i<ar2len;i++)
            {
                result+=array2[i].ToString();
                if(i<ar2len-1)
                    result+=",";
            }
            Console.WriteLine("結果為：{0}",result);
        }
    }
}