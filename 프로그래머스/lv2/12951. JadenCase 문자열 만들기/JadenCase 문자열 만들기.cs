
public class Solution 
{
    public string solution(string s) 
    { 
        
        // 공백문자가 연속으로 나왔다면?
        // splitStr안에 공백문자가 들어가게된다. 그래서 길이가 0인경우를 스킵
        
        string[] splitStr = s.Split(" ");
        string answer = "";
        
        foreach(string str in splitStr)
        {
            if (str.Length ==0)
            {
                answer += " ";
                continue;
            }
            string temp = str.Substring(0,1);
            
            answer += temp.ToUpper();
            
            answer += str.Substring(1,str.Length-1).ToLower();

            answer += " ";
        }
        
        return answer.Substring(0, answer.Length-1);
    }
}