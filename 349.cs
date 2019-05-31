using System;
using System.Text;

namespace IntersectionTwoArrays
{
    class ITA
    {
        static void main(string[] args)
        {
            Console.WriteLine("程式會尋找二個陣列的交集：");
            int[] nums1={1,2,2,1};
            int[] nums2={2,2};
            int[] nums3;
            int counts=0;
            if(nums1.Length>nums2.Length)
                nums3=new int[nums1.Length];
            else
                nums3=new int[nums2.Length];
            for(int i =0;i<nums1.Length;i++)
            {
                for(int j=0;j<nums2.Length;j++)
                {
                    if(nums1[i]==nums2[j])
                    {
                        bool test=true;
                        for(int k=0;k<=counts;k++)
                        {
                            if(nums3[k]==nums1[i])
                                test=false;
                        }
                        if(test)
                        {
                            nums3[counts]=nums1[i];
                            counts+=1;
                        }
                    }
                }
            }
            string returns="";
            for(int l=0;l<counts;l++)
            {
                returns+=nums3[l].ToString();
                if(l<counts-1)
                    returns+=",";
            }
            Console.WriteLine("結果為{0}",returns);
        }
    }
}