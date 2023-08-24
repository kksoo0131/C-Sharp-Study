public class Solution {
    public int solution(string s) {
        int answer = 0;
        string sign = s.Substring(0,1);
        string minus = s.Substring(1,s.Length-1);
        
        
        return sign == "-" ? int.Parse(minus) * -1 : int.Parse(s);
    }
}