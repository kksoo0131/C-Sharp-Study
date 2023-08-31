using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        
        //플레이어 50000 명
        // 자리바꿈 횟수 1 000 000 번
        //최악의 경우 5만명중에서 한명을찾는 작업을 100만번 반복해야됨
        
        // -> 찾는횟수를 줄여야된다. 각선수의 순위를 따로 저장하자 players 는 중복되지 않으니까 Dictionary 사용
        // 앞의선수를 어캐찾지?
        
        
        Dictionary<string,int> playersDic = new Dictionary<string,int>();
        
        for(int i =0; i< players.Length; i++)
        {
            playersDic.Add(players[i], i);
        }
        
        // 선수가 추월할때마다
        // 선수의 순위를 +1해주고
        
        // 플레이어 dic에서 name선수의 순위를 올리고 가져온다.
        // 원래 해당 순위에 있는 선수 정보를 가져온다.
        
        // 두번째 선수의 등수를 내리고
        
        // players에서 두명의 선수의 위치를 조정해준다.
        
        foreach(string name in callings)
        {
            int index = --playersDic[name];
            
            string name2 = players[index];
            playersDic[name2]++;
            
            players[index] = name;
            players[index+1] = name2;
        }
        return players;
    }
}


/* Try 1 시간 초과 발생!!

 public string[] solution(string[] players, string[] callings) {
        
        //이름을 불렀다면 앞의 선수와 자리를 바꾼다?
        
        foreach(string name in callings)
        {
            int index = Array.IndexOf(players, name);
            players[index] = players[index-1];
            players[index-1] = name;
        }
        return players;
    }
*/