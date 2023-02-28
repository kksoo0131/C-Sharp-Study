using System;
using System.Linq;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        for (int x = i; x <= j; x++){
            answer += x.ToString().Count(y => y.ToString() == k.ToString());
        }
        // i부터 j까지 증가하면서 ToString해서 k를 포함하면 answer +1;
        return answer;
    }
}