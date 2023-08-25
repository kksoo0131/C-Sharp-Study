public class Solution {
    public string solution(int a, int b) {
        //각 월의 1일이 무슨 요일인지 계산
        // 1월 금요일 (31 % 7 = 3)
        // 2월 월요일 (29 % 7 = 1)
        // 3월 화요일 
        // 4월 금요일 (30 % 7 = 2)
        // 5월 일요일 
        // 6월 수요일
        // 7월 금요일
        // 8월 월요일
        // 9월 목요일
        // 10월 토요일
        // 11월 화요일
        // 12월 목요일
        
        
        string[][] list = new string[13][];
        // 13인 이유는 인덱스를 맞추려고
        
        list[1] = new string[7] {"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        list[2] = new string[7] {"MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN"};
        list[3] = new string[7] {"TUE", "WED", "THU", "FRI", "SAT", "SUN", "MON"};
        list[4] = new string[7] {"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        list[5] = new string[7] {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};
        list[6] = new string[7] {"WED", "THU", "FRI", "SAT", "SUN", "MON", "TUE"};
        list[7] = new string[7] {"FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        list[8] = new string[7] {"MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN"};
        list[9] = new string[7] {"THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED"};
        list[10] = new string[7] {"SAT", "SUN", "MON", "TUE", "WED", "THU","FRI"};
        list[11] = new string[7] {"TUE", "WED", "THU", "FRI", "SAT", "SUN", "MON"};
        list[12] = new string[7] {"THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED"};
        
        return list[a][(b-1)% 7];
    }
}