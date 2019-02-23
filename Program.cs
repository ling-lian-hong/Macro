using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            string str = "1234";
            char[] strArray = str.ToCharArray();
            p1.AllSequence(strArray);
            Console.ReadKey();
        }

        int DeleteArrayRepet(int[] nums)
        {
            int j = 0;
            int len = nums.Length;
            if (len == 0)
            {
                return 0;
            }
            for (int i = 0; i < len - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[j] = nums[i];
                    j++;
                }
                if (i == len - 2)
                {
                    nums[j] = nums[i + 1];
                }
            }
            return j + 1;
        }

        void AllSequence(char[] s)
        {
            Console.WriteLine(s);
            bool isEnd = false;
            while (!isEnd)
            {
                int[] fromAndToIndex = GetSwapFromAndToIndex(s);
                if (fromAndToIndex != null)
                {
                    SwapChar(s, fromAndToIndex[1], fromAndToIndex[0]);
                    RevertStr(s, fromAndToIndex[0] + 1);
                    Console.WriteLine(s);
                }
                else
                {
                    isEnd = true;
                }
            }
        }

        int[] GetSwapFromAndToIndex(char[] str)
        {
            int[] fromAndTo = new int[2];
            int basis = str.Length - 2;
            int afterBasis = basis + 1;
            fromAndTo[1] = -1;
            while (basis >= 0)
            {
                if (str[basis] < str[afterBasis])
                {
                    if (fromAndTo[1] < 0 || (fromAndTo[1] > 0 && str[fromAndTo[1]] > str[afterBasis]))
                    {
                        fromAndTo[1] = afterBasis;
                    }
                }
                if (++afterBasis > str.Length - 1)
                {
                    if (fromAndTo[1] < 0)
                    {
                        basis--;
                        afterBasis = basis + 1;
                        fromAndTo[1] = -1;
                    }
                    else
                    {
                        fromAndTo[0] = basis;
                        return fromAndTo;
                    }
                }
            }
            return null;
        }

        void SwapChar(char[] s, int i, int j)
        {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
        }

        void RevertStr(char[] str, int from)
        {
            if (str.Length - from <= 1)
            {
                return;
            }
            for (int i = from; i < (str.Length + from) / 2; i++)
            {
                SwapChar(str, i, str.Length - 1 - (i - from));

            }
        }
    }
}
