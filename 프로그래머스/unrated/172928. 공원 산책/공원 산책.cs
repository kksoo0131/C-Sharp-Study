using System;

public class Solution {
    int H;
    int W;
    string[] park;
    
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[] {0,0};
        this.park = park;
        H = park.Length;
        W = park[0].Length;
        
        // 시작지점 찾기
        foreach (string p in park){
            if (p.Contains("S"))
            {
                answer[0] = Array.IndexOf(park, p);
                answer[1] = Array.IndexOf(p.ToCharArray(), 'S');    
            }
            
        }
        
        
        foreach(string route in routes){
            Console.Write(answer[0]+","+answer[1]+"  ");
            answer = CheckDirection(route, answer);
            Console.WriteLine(answer[0]+","+answer[1]);
        }
        
        return answer;
    }
    
    // 갈수 있는지 체크
    int[] CheckDirection(string route, int[] position){
        string direction = route.Substring(0,1);
        int move = int.Parse(route.Substring(2,1));
        int[] vec = new int[]{0,0};
        int[] t_pos = new int[]{position[0], position[1]};
        
        switch(direction){
            case "N":
                for (int i =0; i < move; i++){
                    if(t_pos[0] - 1 < 0 )
                        return position;
                    if(park[t_pos[0]-1][position[1]] == 'X')
                        return position;
                    t_pos[0]--;
                }
                break;
            case "S":
                for (int i =0; i < move; i++){
                    if(t_pos[0] + 1 >= H )
                        return position;
                    if(park[t_pos[0]+1][position[1]] == 'X')
                        return position;
                    t_pos[0]++;
                }
                break;
            case "W": 
                for (int i =0; i < move; i++){
                    if(t_pos[1] - 1 < 0 )
                        return position;
                    if(park[position[0]][t_pos[1]-1] == 'X')
                        return position;
                    t_pos[1]--;
                }
                break;
            case "E":
                for (int i =0; i < move; i++){   
                    if(t_pos[1] + 1 >= W )
                        return position;
                    if(park[t_pos[0]][t_pos[1]+1] == 'X')
                        return position;
                    t_pos[1]++;
                }
                break;
        }
        return t_pos;
        
    }
}