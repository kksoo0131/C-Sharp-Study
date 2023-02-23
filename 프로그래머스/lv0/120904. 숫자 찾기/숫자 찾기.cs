using System;
using System.Linq;

public class Solution {
    public int solution(int num, int k) {
        int answer = -1;
        foreach (char c in num.ToString()){
            if (int.Parse(c.ToString()) == k){
                answer = num.ToString().IndexOf(c) +1;
            }
        }
        return answer;
    }
}