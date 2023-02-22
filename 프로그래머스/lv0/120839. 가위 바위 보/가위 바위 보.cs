using System;
using System.Linq;


public class Solution {
    public string solution(string rsp) {
        return String.Concat( rsp.Select( x => x =='2' ? '0' : x == '0' ? '5' : '2'));
    }
}