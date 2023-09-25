using System;
using System.Collections.Generic;

public class Solution 
{
    // 사전에 순서대로 단어가 들어가있음
    // 같은 단어로 다채우고, 마지막 단어부터 돌아간다. -> DFS?
    
    // A AA AAA AAAA AAAAA
    // AAAAE AAAA\
    
    string[] words = {"A", "E", "I", "O", "U"};
    List<string> dictionary = new List<string>();
    
    public void MakeDictionary(string str,int depth)
    {
        if(depth >4) return;
        
        int length = str.Length;
        
        foreach(string word in words)
        {
            str += word;
            dictionary.Add(str);
            MakeDictionary(str,depth+1);
            str = str.Substring(0,length);
        }   
    }

    public int solution(string word) 
    {
        int answer = 0;
        MakeDictionary("", 0);
        
        for(int i =0; i< dictionary.Count; i++)
        {
            if (dictionary[i] == word)
            {
                answer = i+1;
                break;
                
            }
        }
        return answer;
    }
}