using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        // 목표단어를 만들수 있는가?
        // 각 cards뭉치 내의 카드의 순서를 지켜야된다.
        // cards에는 중복이없음
        int cards1Index = 0;
        int cards2Index = 0;
        
        foreach(string s in goal)
        {
            if(cards1Index < cards1.Length && cards1[cards1Index] == s)
            {
                cards1Index++;
            }
            else if(cards2Index < cards2.Length && cards2[cards2Index] ==s)
            {
                cards2Index++;    
            }
            else
            {
                return "No";
            }    
            
        }
        return "Yes";
    }
}