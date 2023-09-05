using System;

public class Solution 
{
    // 1. 모든 0을 제거
    // 2. 그때의 길이를 2진법으로 변환
    // 3. s가 1이 될때까지 반복
    // 4. return 횟수, 제거된 0의 개수
    int[] answer = new int[2];
    public int[] solution(string s) 
    {
        while (s != "1")
        {
            s = BinaryConversion(s);
            s = LengthToBinary(s);
            s = ReverseString(s);
            answer[0] += 1;
        }
          
        return answer;
    }
    
    public string BinaryConversion(string s)
    {
        string temp = "";
        foreach(char c in s)
        {
            if (c == '1')
            {
                temp +=c;
            }
            else
            {
                answer[1] +=1;    
            }
        }
        
        return temp;
    }
    
    public string LengthToBinary(string s)
    {
        int length = s.Length;
        
        string binary = "";
        
        while(length > 0)
        {
            binary += length % 2;
            length /=2;
        }
        
        return binary;
        
    }
    
    public string ReverseString(string s)
    {
        string reverse = "";
        
        for (int i= s.Length-1 ; i >= 0 ; i--)
        {
            reverse += s[i];
        }
          
        return reverse;
    }
        
}
