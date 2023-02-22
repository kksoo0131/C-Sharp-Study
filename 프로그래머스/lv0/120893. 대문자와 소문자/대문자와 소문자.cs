using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        return String.Concat(my_string.Select( c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c) ) );
    }
}