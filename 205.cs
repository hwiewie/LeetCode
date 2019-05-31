using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace QuickSort
{
    class ObjectOriented
    {
        public static void quickSort(char[] list, int left, int right) {
            if (left < right) {
                int pivot = partition(list, left, right);
                quickSort(list, left, pivot - 1);
                quickSort(list, pivot + 1, right);
            }
        }

        private static int partition(char[] list, int left, int right) {
            int i = left - 1;
            int j = right;
            char pivot = list[right];        // 取分區的基準元素

            while (true) {
                while (list[++i] < pivot)   // 右向指標
                    if (i == right)
                        break;
                while (list[--j] > pivot)    // 左向指標
                    if (j == left)
                        break;
                if (i >= j)             // 將左右指標交會?
                    break;
                swap(list, i, j);         // 將左右指標所指元素對調
            }
            swap(list, i, right);         // 左指標所指元素和基準元素對調
            return i;
        }

        public static void swap(char[] list, int left, int right) {
            char temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("請輸入字串s：");
            string s = Console.ReadLine();
            Console.WriteLine("請輸入字串2：");
            string t = Console.ReadLine();
            char[] charx = s.ToCharArray();
            char[] chary = t.ToCharArray();
            quickSort(charx, 0, charx.Length - 1);
            quickSort(chary, 0, chary.Length - 1);
            string x = new String(charx);
            string y = new String(chary);
            int comparison = String.Compare(x,y,ignoreCase: true);
            if (comparison==0)
                Console.WriteLine("s與t為同構字")
            else
                Console.WriteLine("s與t不是同構字")
        }
    }
}