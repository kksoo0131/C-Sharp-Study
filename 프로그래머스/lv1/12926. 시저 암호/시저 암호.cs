using System;
public class Solution {
    public string solution(string s, int n) 
    {
        
        // 입력받은 문자열을 n만큼씩 다 밀어버린다 
        // 아스키코드를 사용하고 범위를 벗어나면 처음으로 돌아가게 한다.
        // 대문자는 65~90, 소문자는 97 ~122
        
        string answer= "";
        
        foreach(char c in s)
        {
            if(c == ' '){
                answer+= c;
                continue;
            }
            
            char temp = (char)(c + n);
            temp =  (c <= 90 && temp > 90) || (temp > 122) ? (char)(temp - 26) : temp;
            answer += temp.ToString();
        }
        return answer;
    }
}