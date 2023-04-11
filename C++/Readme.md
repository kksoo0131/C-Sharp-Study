# 자주 쓰이는 클래스와 메소드들

1. 벡터 vector<T> name(size);
  ``` cpp
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
