# 자주 쓰이는 클래스와 메소드들
1. 스트링 string name = "str";

  ``` cpp
    #include <iostream>
    #include <string>
    using namespace std;
    
    string str = "Mystr"; // 생성
  
    cin >> str; // 공백 전 까지의 문자열만 입력받는다 
    
    getline(cin, str); // \n 전까지의 문자열을 입력받는다. 
    
    str[i] // i위치의 문자 반환
    
    str.length() // 문자열 길이 반환
    
    str.find(str2) // 문자열 str2가 str에 포함되어 있는지 확인. 해당 부분의 첫번째 index반환
    
    str.find(str2, n)// 인덱스 n부터 str.find(str2)를 실행
    
    str.substr(n,k) // n번째의 index부터 k개의 문자를 부분문자열로 반환
    
  ```
  
2. 벡터 vector<T> name(size);
  
  ``` cpp
    #include <vector>
    using namespace std;
  
    vector<int> v1 = {1,2,3}; // 생성
  
    v.begin(); // 시작 주소값
  
    v.end(); // 끝부분+1 주소값
  
    v[i]; // i번쨰 요소에 접근
  
    v.emplace_back // v.end()의 위치에 요소를 추가
  
    v.emplace(v.begin()+i, value) // i번쨰 위치의 요소를 value로 변경
  
    v.insert(v.begin()+1, value) // i번째 위치에 value를 삽입
  
    v.pop_back(); // 마지막 요소를 제거
  
    v.clear(); // 벡터의 모든 요소 제거
  
    v.erase(i) // i번쨰 위치의 요소를 제거
  
    v.size(); // 벡터의 크기 반환
  ```

 
