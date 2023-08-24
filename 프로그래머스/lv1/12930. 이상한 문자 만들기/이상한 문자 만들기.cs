public class Solution {
    public string solution(string s) {
        string[] strArray = s.Split(" ");
        string answer = "";
        
        foreach(string str in strArray)
        {
            for(int i =0; i< str.Length; i++){
                answer += i % 2 == 0 ? str[i].ToString().ToUpper() : str[i].ToString().ToLower();
            }
            answer += " ";
        }
        
        // 마지막 공백을 지워줘야됨
        return answer.Substring(0, answer.Length-1);
    }
}