using System;

public class Solution {
    public int solution(int[] common) {
        // 등차수열 인지 등비 수열인지 판단해서
        int r = common[1] -common[0];
        if (common[1] + r == common[2])
            return common[common.Length-1]+r;
        r = common[1] / common [0];
        return common[common.Length-1] * r;
        
    }
}