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

 3. 맵 map<key,value> map1;
 
 ```cpp
 #include <map>
 
 map<stirng, int> m1; // 생성 <key, value> 키 값은 중복 x
 
 m1.insert({"string", 1}); // 삽입 이미가지고 있는 key는 무시
 
 m1["string"] // key값으로 인덱스 접근, 삽입 (새로운 키를 넣으면 value는 0)
 
 m1["string"] = 2 // value 값을 변경
 
 m1["string"]++; // value값을 ++
 
 for(pair<string, int> p : m1){
  cout << p.first << " " << p.second << endl;
 } // 전체 순회
 
 m1.find("string2") // key를 찾아 접근자를 반환 없을경우 end()반환
 
 m1.erase("string"); // 원하는 key값을 가진 노드 삭제
 
 map.erase(map.begin() + i); // i 위치의 노드를 삭제
 
 map.erase(map.begin()+i, map.begin()+i+k) // i위치부터 k개의 노드를 삭제
 
 map.clear() // 비우기
 
 map.size() // map의 크기
 
 
 ```
