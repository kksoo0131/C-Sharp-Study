using System;

public class Solution {
    public int solution(int[] box, int n) {
        
        for (int i =0; i<3 ; i++){
            box[i] /= n;
        }
        return box[0] * box[1] * box[2];
    }
}