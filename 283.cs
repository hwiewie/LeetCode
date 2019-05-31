using System;
using System.Text;

namespace MoveZeros
{
    class movezero
    {
        static void main(string[] args)
        {
            Console.WriteLine("給個陣列，程式會把裡面出現的0搬到最後：");
            int[] nums={0,1,0,3,12};
            int countzero=0;
            int skip=0;
            string result="";
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]==0)
                {
                    countzero+=1;
                    skip+=1;
                    continue;
                }
                if(skip>0)
                {
                    nums[i-skip]=nums[i];
                }
            }
            for(int j=nums.Length-1;j>=nums.Length-countzero;j--)
            {
                nums[j]=0;
            }
            for(int k=0;k<nums.Length;k++)
            {
                result+=nums[k].ToString();
                if(k<nums.Length-1)
                    result+=",";
            }
            Console.WriteLine("結果為{0}",result);
        }
    }
}