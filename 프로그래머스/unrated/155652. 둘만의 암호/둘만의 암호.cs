using System;

public class Solution {
    // 입력받은 문자열 s의 각 자리를 index 만큼 뒤로 밀어줌
    // skip에 있는 알파벳은 제외
    
    public string Skip {get;set;}
    
    public string solution(string s, string skip, int index) {
        Skip = skip;
        string answer = "";
        
        foreach(char c in s)
        {
            answer += PushAlphabet(c,index);
        }
        return answer;
    }
    // 소문자 아스키 코드 범위는 97~122, 123부터는 -26
    public char PushAlphabet(char target,int count)
    {
        int temp = (int)target;
        while(count-- > 0)
        {
            temp++;
            if(temp >= 123)
            {
                temp -= 26;    
            }
            while(Skip.Contains((char)temp))
            {
                temp++;
                if(temp >= 123)
                {
                    temp -= 26;    
                }              
            }

            
        }

        return (char)temp;
    }
}