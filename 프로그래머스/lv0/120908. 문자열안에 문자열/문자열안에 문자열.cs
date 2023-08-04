using System;

public class Solution {
    public int solution(string str1, string str2) 
    {
        /*
        int str1Index = 0;
        int str2Index = 0;
        bool isContains = false;
        
        while(str1Index  < str1.Length)
        {
            if (str1[str1Index++] != str2[str2Index++])
            {
                str2Index = 0;
            }
            
            if (str2Index == str2.Length){
                isContains = true;
                break;
            }                     
        }
        
        return isContains ? 1 : 2;
        */
        
        return str1.Contains(str2) ? 1 : 2;;
    }
}