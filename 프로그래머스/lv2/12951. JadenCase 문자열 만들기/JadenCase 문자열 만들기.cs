public class Solution {
    public string solution(string s) {
        string[] temp = s.Split(" ");
        string answer = "";
        
        foreach (string ss in temp){
            // 연속 공백문자 방지
            if (ss.Length == 0){
                answer += " ";
                continue;
            }
            
            //첫 문자 숫자 방지
            if (int.TryParse(ss[0].ToString(), out _)){
                answer += ss.ToLower()+" ";
            }
            else    
                answer += char.ToUpper(ss[0]) + ss.Substring(1).ToLower()+" ";          
        }       
        // 마지막 공백문자 제거
        return answer.Substring(0,answer.Length-1);
    }
}