using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        List<string> list = new List<string>();
        
        int failNum = 0;
        char lastWord = words[0][words[0].Length-1];
        list.Add(words[0]);
        
        
        
        for (int i=1; i< words.Length; i++){
            // 끝말이 안 이어진 경우
            if (words[i][0] != lastWord){
                failNum = ++i;
                break;
            }
            
            // 나왔던 단어를 또 말한경우
            if (list.Contains(words[i])){
                failNum = ++i;
                break;
            }
            
            // 통과
            list.Add(words[i]);
            lastWord = words[i][words[i].Length-1];
        }
        
        // 탈락자가 없다면
        if (failNum ==0)
            return new int[] {0,0};
    
        if (failNum % n == 0)
            return new int[] {n - failNum % n, failNum / n };
        else
            return new int[] {failNum % n, failNum / n + 1 };
    }
}