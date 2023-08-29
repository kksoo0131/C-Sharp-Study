using System;

public class Solution {
    //keymap에 따라서
    //targets 문자열을 만들기위해서 키를 최소몇번씩 눌러야하는지 순서대로 return
    // 만들수 없는 경우 -1
    string[] _keymap;
    string[] _targets;
    
    public int[] solution(string[] keymap, string[] targets) 
    {
        
        _keymap = keymap;
        _targets = targets;
        int[] answer = new int[_targets.Length];
        
        for(int i =0; i< _targets.Length; i++)
        {
            int count = 0;
            foreach(char c in _targets[i])
            {
                if (KeyCheck(c) != -1)
                {
                    count += KeyCheck(c);
                }
                else
                {
                    count = -1;
                    break;
                }
            }
            answer[i] = count;
        }
        
        return answer;
    }
    
    // 키하나를 체크
    public int KeyCheck(char checkKey)
    {
        // keymap을 확인하려는 key로 split했을때
        // return되는 문자열이 하나면 key가없음
        // 두개면 앞의 문자열의 길이가 index?
        // 이러면 근데 제일 앞과 제일뒤에 당첨됬을때 인식 x -> if 문 추가
        int min = int.MaxValue;
        foreach(string key in _keymap)
        {
            string[] temp = key.Split(checkKey);
            
            if(temp.Length > 1)
            {
                // 중간 어딘가.
                 min = Math.Min(temp[0].Length+1, min);
            }
            
            // temp.Length가 1일때만 아래 조건을 처리해야되서 if문 순서 중요
            else if (key.Substring(0, key.Length-1) == temp[0])
            {
                // 제일 마지막 키일 때
                min = key.Length;
            }
            else if (key.Substring(1, key.Length-1) == temp[0])
            {
                // 제일 첫 키일 때  
                min = 1;
            }
            
        }
        
        return min == int.MaxValue ? -1 : min;
    }
}