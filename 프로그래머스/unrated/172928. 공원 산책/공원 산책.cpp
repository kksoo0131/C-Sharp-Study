#include <iostream>
#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<string> park, vector<string> routes) {
    vector<int> answer{0,0};
    int H = park.size();
    int W = park[0].length();
    
    for (int i =0; i<H ; i++){
        int W_index = park[i].find("S");
        
        if( W_index != string::npos)
        {
            answer[0] = i;
            answer[1] = W_index;
            break;
        }
    }
    
    for(string route : routes){
        string direction = route.substr(0,1);
        int move = stoi(route.substr(2,1));
        bool check_index = true;
        bool check_wall = true;

        switch(direction[0]){
            case 'N' :
                if(answer[0] - move < 0)
                    check_index = false;
                break;
            case 'S' :
                if(answer[0] + move >= H)
                    check_index = false;
                break;
            case 'W' :
                if(answer[1] - move < 0)
                    check_index = false;
                break;
            case 'E' :
                if(answer[1] + move >= W)
                    check_index = false;
                break;
        }
    
        if (!check_index) continue;
        
        switch(direction[0]){
        case 'N' :
            for (int i =1; i <= move; i++){
                if(park[answer[0]-i][answer[1]] == 'X'){
                    check_wall= false;
                    break;
                }
                    
            }
            break;
        case 'S':
            for(int i =1; i<= move; i++){
                if(park[answer[0]+i][answer[1]] == 'X'){
                    check_wall= false;
                    break;
                }
                    
            }
            break;
        case 'W':
            for(int i =1; i<= move; i++){
                if(park[answer[0]][answer[1]-i] == 'X'){
                    check_wall= false;
                    break;
                }
            }
            break;
        case 'E':
            for(int i =1; i<= move; i++){
                if(park[answer[0]][answer[1]+i] == 'X'){
                    check_wall= false;
                    break;
                }
            }
            break;
    }
        
    if (!check_wall) continue;
        
    switch(direction[0]){
        case 'N' :
            answer[0] -= move;
            break;
        case 'S':
            answer[0] += move;
            break;
        case 'W':
            answer[1] -= move;
            break;
        case 'E':
            answer[1] += move;
            break;
    }

        
    }
    
    return answer;
}



    
