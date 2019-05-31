using System;
using System.Text;

namespace IntersectionOfTwoArraysII
{
    class IOTAII
    {
        static private string returnunion(int[] nums1,int[] nums2)
        {
            int[] result;
            int k=0;
            if(nums1.Length>nums2.Length)
                result=new int[nums1.Length];
            else
                result=new int[nums2.Length];
            for(int i=0;i<nums1.Length;i++)
            {
                for(int j=0;j<nums2.Length;j++)
                {
                    if(nums1[i]==nums2[j])
                    {
                        result[k]=nums1[i];
                        nums2[j]=-3345678;
                        k+=1;
                    }
                }
            }
            string returns="";
            for(int l=0;l<k;l++)
            {
                returns+=result[l].ToString();
                if(l<k-1)
                    returns+=",";
            }
            return returns;
        }
        static void main(string[] args)
        {
            Console.WriteLine("尋找兩個陣列的交集");
            int[] nums1={1,2,2,1};
            int[] nums2={2,2};
            Console.WriteLine("結果為{0}",returnunion(nums1,nums2));
        }
    }
}