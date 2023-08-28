using System;

public class Solution {
    // 첫글자의 글자수와 첫글자가 아닌글자의 글자수를 센다.
    
    public int solution(string s) {
        int index = 0;
        int answer = 1;
        
        char temp = s[0];
        int tempCount = 1;
        int notTemp = 0;
        
        while(++index < s.Length)
        {
            if(tempCount == 0 && notTemp == 0)
            {
                answer++;
                temp = s[index];
            }
                 
            if( s[index] == temp)
            {
                tempCount++;
            }
            else
            {
                notTemp++;
            } 
            
            if (tempCount == notTemp)
            {
                tempCount = 0;
                notTemp = 0;  
            }
            
           
        }
        
        return answer;
    }

}