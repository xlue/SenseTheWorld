
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenseLue.Code.Algorithm
{
    public class LeetCode
    {


        public static int FindComplement(int num)
        {
            string OXE = Convert.ToString(num, 2);
            string str = string.Empty;
            for (int i = 0; i < OXE.Length; i++)
            {
                if (OXE[i].ToString() == "1")
                {
                    str += "0";
                }
                else
                {
                    str += "1";
                }
            }

            return Convert.ToInt32(str, 2);
        }



        //Keyboard Row
        public static string[] FindWords(string[] words)
        {
            char[] row1 = new[] { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
            char[] row2 = new[] { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
            char[] row3 = new[] { 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

            List<string> resultWord = new List<string>(); 

            for (int i = 0; i < words.Length; i++)
            {
                int one = 0, two = 0, three = 0;
                foreach(char c in words[i].ToUpper())
                {
                    if (row1.Contains(c)) one = 1;
                    if (row2.Contains(c)) two = 1;
                    if (row3.Contains(c)) three = 1;
                    if (one + two + three > 1) break;
                }
                if (one + two + three == 1) resultWord.Add(words[i]);
            }
            return resultWord.ToArray();
        }

        public static string AddBinary(string a, string b)
        {
            string result = string.Empty;
            long sumA = 0, sumB = 0, sum = 0;
            int sumALength = a.Length;
            int sumBLength = b.Length;
            for (int i = sumALength - 1; i >= 0; i--)
            {
                long t = 1;
                for (int j = 0; j < i; j++)
                {
                    t *= 2;
                }
                sumA += t * int.Parse(a[sumALength - 1 - i].ToString());
            }

            for (int i = sumBLength - 1; i >= 0; i--)
            {
                long t = 1;
                for (int j = 0; j < i; j++)
                {
                    t *= 2;
                }
                sumB += t * int.Parse(b[sumBLength - 1 - i].ToString());
            }
            sum = sumA + sumB;
            while (sum != 0)
            {
                result += (sum % 2).ToString();
                sum = sum / 2;
            }
            string resultS = string.Empty;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                resultS += result[i].ToString();
            }
            return resultS == "" ? "0" : resultS;
        }
    }
}
