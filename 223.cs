using System;
using System.Text;

namespace RectangleArea
{
    class Rectarea
    {
        static private int convarea()
        {
            int a=-3,b=0,c=3,d=4,e=0,f=-1,g=9,h=2;
            int high=0,weight=0;
            if(a<=e)
            {
                if(c>=e)
                {
                    if(g>=c)
                        weight=c-e;
                    else
                        weight=g-e;
                    if(b<=f)
                    {
                        if(d>=f)
                        {
                            if(h>=d)
                                high=d-f;
                            else
                                high=h-f;
                        }
                        else
                            return 0;
                    }
                    else
                    {
                        if(h>=b)
                        {
                            if(d>=h)
                                high=h-b;
                            else
                                high=d-b;
                        }
                        else
                            return 0;
                    }
                }
                else
                    return 0;
            }
            else
            {
                if(g>=a)
                {
                    if(c>=g)
                        weight=g-a;
                    else
                        weight=c-a;
                    if(b<=f)
                    {
                        if(d>=f)
                        {
                            if(h>=d)
                                high=d-f;
                            else
                                high=h-f;
                        }
                        else
                            return 0;
                    }
                    else
                    {
                        if(h>=b)
                        {
                            if(d>=h)
                                high=h-b;
                            else
                                high=d-b;
                        }
                        else
                            return 0;
                    }
                }
                else
                    return 0;
            }
            return high*weight;
        }
        static public void main(string[] args)
        {
            Console.WriteLine("程式會計算二個矩型重疊的面積：");
            Console.WriteLine("重疊面積為：{0}",convarea());
        }
    }
}