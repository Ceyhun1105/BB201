using System.Text.RegularExpressions;

namespace Stringmethodscustom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ceyeyhuyney";
            Console.WriteLine(LastİndexOf(name, 'y'));
            Console.WriteLine(Contains(name, "h"));
            Console.WriteLine(Replace(name, "C", "T"));
            Console.WriteLine(Trim("      wdwdewdw dwqwdwd    "));
            Console.WriteLine(Substring(name,2,6));
            Console.WriteLine(Substring(name,2));

        }
      
        static int LastİndexOf(string word, char ch)
        {
            int result = 0;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (word[i] == ch)
                {
                    result = i;
                    break;
                }

            }
            return result;
        }

        static bool Contains(string word, string str)
        {
            bool result = false;
            int re = 0;
            for (int i = 0; i < word.Length; i++)
            {
                bool contain = true;
                if (word[i] == str[0])
                {
                    contain = true;
                    re = i;
                    int countstr = 0;
                    for (int j = re; j < str.Length; j++)
                    {
                        if (word[j] != str[countstr])
                        {
                            contain = false;
                            break;
                        }
                        countstr++;
                    }
                }
                else
                {
                    contain = false;
                }

                if (contain)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        static string Replace(string str, string rp1, string rp2)
        {
            string result = str;
            string finish = String.Empty;
            bool have = Contains(str, rp1);
            char[] chars = str.ToCharArray();
            string[] strs = new string[chars.Length];
            int countnew = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                countnew = 0;
                strs[i] = Convert.ToString(chars[i]);
            }
            if (have)
            {
                bool contain = false;
                int re = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    contain = true;
                    if (strs[i] == Convert.ToString(rp1[0]))
                    {
                        contain = true;
                        re = i;
                        int countstr = 0;
                        for (int j = re; j < rp1.Length; j++)
                        {
                            if (strs[j] != Convert.ToString(rp1[countstr]))
                            {
                                contain = false;
                                break;
                            }
                            countstr++;
                        }
                        countnew = countstr;

                    }

                    if (contain)
                    {
                        for (int p = re + 1; p < countnew; p++)
                        {
                            strs[p] = " ";
                        }
                        strs[re] = rp2;
                    }
                }
                for (int t = 0; t < strs.Length; t++)
                {
                    if (strs[t] != " ")
                    {
                        finish += strs[t];
                    }
                }
            }


            return finish;

        }

        static string Trim(string word)
        {
         
            bool Space= true;
            int i = 0;
            int j= word.Length-1;
            while (Space)
            {
                if (word[i] != ' ') Space= false;
                i++;
            }
            while (Space)
            {
                if (word[j] != ' ') Space = false;
                j--;
            }
            string result=string.Empty;
            for(int t=i-1;t<=j;t++)
            {
                result += word[t];
            }
            return result;
        }

        static string Substring(string word, int start, int stop)
        {
            string result = string.Empty;   

            for (int i = start; i < stop; i++)
            {
                result+= word[i];
            }
            return result;
        }
        static string Substring(string word, int start)
        {
            string result = string.Empty;
            for(int i = start; i < word.Length; i++)
            {
                result+= word[i]; 
            }
            return result;
        }

    }
    }
