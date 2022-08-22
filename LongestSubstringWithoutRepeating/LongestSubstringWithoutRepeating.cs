using System;
using System.Text;
using System.Linq;

class LongestSubstringWithoutRepeating {

    public static void Main() {
        String str = "dvdf";
        Console.WriteLine(
            LengthOfLongestSubstring(str)
        );
    }

    public static int LengthOfLongestSubstring(string s) {
        StringBuilder sb = new StringBuilder();
        String answer = "";
        
        foreach (char letter in s) {
            
            if (!sb.ToString().Contains(letter)) {
                sb.Append(letter);
            }
            else {
                if (sb.Length >= answer.Length)
                    answer = sb.ToString();
                //Console.WriteLine(sb.ToString()+" | "+answer+" | "+sb.ToString().LastIndexOf(letter)+" | letter : "+letter);
                sb = sb.Remove(0,sb.ToString().LastIndexOf(letter)+1);
                sb.Append(letter);
            }  
        }

        if (sb.Length >= answer.Length)
            answer = sb.ToString();
        if (answer == "")
            answer = sb.ToString();

        return answer.Length;
    }
}