
namespace Extentions
{
    public static class HelperExtentions
    {


        public static int MatchCount(this string sentence, string reply)
        {

            int count = 0;
            for (int i = 0; i < sentence.Length; i++)  // ananas1 an
            {
                
                bool possible = true;
                if (i == sentence.Length - reply.Length+1) break;
                if (sentence[i] != reply[0]) continue;
                
                
                    for (int j = i+1, t = 1; j < i + reply.Length; j++, t++)
                    {
                        if (sentence[j] != reply[t]) possible = false;
                    }
                    if (possible) count++;
                
            }
            return count;
        }

        public static bool HasAnyDigit(this string sentence) 
        {
            foreach(char item in sentence)
            {
                if(char.IsDigit(item)) return true;
            }
            return false;
        }
        
        public static bool Polindrom(this int number) 
        {
           
            string num = number.ToString();  // 4444
            int center = num.Length / 2;   // 1 
            string reverse=String.Empty;
            for(int i=num.Length-1;i>center-1 ;i--)
            {
                reverse += num[i];
            }
            if (num.Length % 2 == 0)
            {
                if (num.Substring(0, center) == reverse) return true;
                return false;
            }
            else
            {
                if (num.Substring(0, center + 1 ) == reverse) return true;
                return false;
            }
        }
    }
}
