using System;

public class Solution {
    public bool solution(int x) {
        string str = x.ToString();
        int sum = 0;
        
        foreach(char c in str){
            sum += int.Parse(c.ToString());
        }
        
        return x % sum == 0 ? true : false;
    }
}