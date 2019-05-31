using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class ValidPalindrome
    {
        private bool ifpalindrome(string str)
        {
            string trim = Regex.Replace(str ,@"\s\d","");
            trim = trim.ToLower();
            char[] charArray = trim.ToCharArray();
            Array.Reverse(charArray);
            string revertrim = new String(charArray)
            if(String.Compare(trim,revertrim,true)==0)
                return true;
            else
                return false;
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一段字串，程式會判斷是否為迴文：");
            string templine = Console.ReadLine();
            if(ifpalindrome(templine))
                Console.WriteLine("這個字串是迴文");
            else
                Console.WriteLine("這個字串不是迴文");
        }
    }
}