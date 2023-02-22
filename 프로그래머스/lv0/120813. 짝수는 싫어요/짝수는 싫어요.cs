using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        return Enumerable.Range(1,n).Where(x => x %2 ==1).ToArray();
    }
}