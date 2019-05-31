using System;
using System.Text;
using System.Collections;

namespace MajorityElement
{
    class ME
    {
        public static int[] ShellSortCorrect(int[] data)
        {
            int temp;
            for (int gap = data.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < data.Length; i++)
                {
                    temp = data[i];
                    for (int j = i - gap; j >= 0; j -= gap)
                    {
                        if (data[j] > temp)
                        {
                            data[j + gap] = data[j];
                            if (j == 0)
                            {
                                data[j] = temp;
                                break;
                            }
                        }
                        else
                        {
                            data[j + gap] = temp;
                            break;
                        }
                    }
                }
            }
            return data;
        }
        static void main(string[] args)
        {
            Console.WriteLine("找出一個在長度為n的陣列中出現n/2次以上的主要元素：");
            int[] numarray={1,1,1,1,1,2,2,2,1,2,2,3,3,1,1};
            //List<int> numarray = new List<int>(nums);
            int count=0,result=-1,temp=-1;
            ShellSortCorrect(numarray);
            for(int i=0;i<numarray.Length;i++)
            {
                if(numarray[i]==temp)
                {
                    count+=1;
                    if(count>numarray.Length/2)
                    {
                        result=temp;
                        break;
                    }
                }
                else
                {
                    if(count>numarray.Length/2)
                    {
                        result=temp;
                        break;
                    }
                    temp=numarray[i];
                    count=0;
                }
            }
            Console.WriteLine("主要元素為：{0}",result);
        }
    }
}