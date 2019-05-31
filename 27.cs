using System;
using System.Text;

namespace RemoveElement
{
    class RE
    {
        static int returnarray(int[] nums,int num)
        {
            int j=0;
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]==num)
                {
                    j+=1;
                }
            }
            return nums.Length-j;
        }
        static void main(string[] args)
        {
            Console.WriteLine("給一個陣列跟一個數字，移除陣列中所有跟數字相同的元素。");
            Console.WriteLine("請給一個數字：");
            int[] arrays={3,1,2,3,2,1,4,5,3,4,5,6,7,6,9,8,8,9,7};
            string temp = Console.ReadLine();
            int num = Convert.ToInt32(temp);
            Console.WriteLine("陣列長度為：{0}",returnarray(arrays,num));
        }
    }
}