public class Solution {
    public string solution(string s) {
        string[] temp = s.Split(" ");
        string answer = "";
        
        foreach (string ss in temp)
        {
            answer += ss.Length == 0 ? " " : char.ToUpper(ss[0]) + ss.Substring(1).ToLower()+" ";
        }
        return answer.Substring(0,answer.Length-1);
    }
}