using System;
using System.Linq;

public class Solution {
    public int solution(string my_string) {
        return my_string.Where(x => char.IsNumber(x)).Sum(x => int.Parse(x.ToString()));
    }
}