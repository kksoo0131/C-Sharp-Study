using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after) {
        int[] alphabet1 = Enumerable.Repeat(0,26).ToArray();
        int[] alphabet2 = Enumerable.Repeat(0,26).ToArray();
        foreach (char c in before){
           alphabet1[(int)c - 97] +=1;
        }
        foreach (char c in after){
           alphabet2[(int)c - 97] +=1;
        }
        
        for (int i =0; i < 26; i++)
            if(alphabet1[i] != alphabet2[i])
                return 0;
        return 1;
    }
}