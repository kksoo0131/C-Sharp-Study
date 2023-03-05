using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        bool id_check = false;
        bool pw_check = false;
    
        for (int i=0 ; i < db.GetLength(0); i++){
            if(db [i,0] == id_pw[0])
                id_check = true;
        }
        
        if (id_check == false)
            return "fail";
        
        for (int i=0 ; i < db.GetLength(0); i++){
            if(db [i,0] == id_pw[0] && db [i,1] == id_pw[1])
                pw_check = true;
        }
        
        if (pw_check == false)
            return "wrong pw";
        
        return "login";

    }
}