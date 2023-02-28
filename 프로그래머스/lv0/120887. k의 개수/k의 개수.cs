using System;
using System.Linq;

public class Solution {
    public int solution(int i, int j, int k) {
      return Enumerable.Range(i, j-i+1)
            .Select( x => x.ToString().Count(y => y.ToString() == k.ToString()))
            .Sum();
    }

}