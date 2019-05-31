using System;
using System.Text;

namespace STI
{
    class atoi
    {
        private int returnnum(string str)
        {
            bool miner = false;
            string trim = Regex.Replace(str ,@"\s","");
            int result = 0;
            if(str.StartsWith("-")
                miner = true;
            trim = trim.Replace("-","");
            trim = trim.Replace("+","");
            if(trim.Length>10)
                return 0;
            if(trim[0]>"2")
                return 0;
            else if(trim[0]=="2")
            {
                if(trim[1]>"1")
                    return 0;
                else if(trim[1]=="1")
                {
                    if(trim[2]>"4")
                        return 0;
                    else if(trim[2]=="4")
                    {
                        if(trim[3]>"7")
                            return 0;
                        else if(trim[3]=="7")
                        {
                            if(trim[4]>"4")
                                return 0;
                            else if(trim[4]=="4")
                            {
                                if(trim[5]>"8")
                                    return 0;
                                else if(trim[5]=="8")
                                {
                                    if(trim[6]>"3")
                                        return 0;
                                    else if(trim[6]=="3")
                                    {
                                        if(trim[7]>"6")
                                            return 0;
                                        else if(trim[7]=="6")
                                        {
                                            if(trim[8]>"4")
                                                return 0;
                                            else if(trim[8]=="4")
                                            {
                                                if(miner)
                                                {
                                                    if(trim[9]>"7")
                                                        return 0;
                                                }
                                                else
                                                {
                                                    if(trim[9]>"8")
                                                        return 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Int32.TryParse(trim,out result);
            return result;
        }
        static void main(string[] args)
        {
            Console.WriteLine("請輸入一段數字，程式會將字串轉成數字，大小介於2147483647到-2147483648之間：");
            string tempnum = Console.ReadLine();
            Console.WriteLine("結果為：%d",returnnum(tempnum));
        }
    }
}