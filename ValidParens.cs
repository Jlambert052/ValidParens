namespace Leetcode {
    public class ValidParen {
        public bool IsValid(string s) {
            bool isValid = true;
            int count = 0;
            int length = s.Length;
            char[] stack = new char[length];
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('(',')');
            dict.Add('[',']');
            dict.Add('{','}');

            for(int i =0; i < length; i++) {
                if(dict.ContainsKey(s[i])) {
                    stack[count++]=dict[s[i]];
                }
                else if (count == 0 || stack[--count] != s[i]) {
                    isValid = false;
                    break;
                }
            }
            return isValid && count == 0;
        }
    }
}