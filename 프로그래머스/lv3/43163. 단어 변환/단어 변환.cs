using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    
    public int[] answer;
    public List<string> words;
    public char[] alphabet;
    
    public int solution(string begin, string target, string[] words) {
        this.words = words.ToList();    
        alphabet = new char[] 
        {'a','b','c','d','e','f','g',
         'h','i','j','k','l','m','n',
         'o','p','q','r','s','t','u',
         'v','w','x','y','z'};   
        answer = Enumerable.Repeat(0,words.Length+1).ToArray();
        
        if (Array.Exists<string>(words, x => x == target) == true){
            bfs(begin, target);
            return answer[Array.IndexOf(words, target)]-1 ;
        }
        else
            return 0;
    }
    
    void bfs (string start, string target){
        
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(start);
        words.Add(start);
        answer[words.IndexOf(start)] = 1;
               
        while(queue.Count >0){ 
            start = queue.Dequeue();
            
            if (start == target)
                return;
            
            for (int i =0; i< start.Length; i++){
                for (int j=0; j< alphabet.Length; j++){ 
                    
                    char[] array = start.ToCharArray();
                    array[i] = alphabet[j];
                    //한 자리만 다른 알파벳으로 바꾸기
                    string temp = new string(array);
                    
                    // 단어가 없다면
                    if (words.Exists(x => x==temp) == false)
                        continue;

                    //이미 들렸던 곳이라면 (더 빠른게 있기 때문에)
                    if (answer[words.IndexOf(temp)] > 0 )
                        continue;

                    queue.Enqueue(temp);
                    answer[words.IndexOf(temp)] = answer[words.IndexOf(start)] +1; } } }
        
            // target이 words안에 있지만 도달하지는 못한경우
            answer[words.IndexOf(target)] =1;
    
        }          
    }         
