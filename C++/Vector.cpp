// 벡터
#include <vector>
int main()
{
  //Vector Init;
  vector<int> v = {1, 2, 3}; // vector<T> name; 형태로 선언
  vector<int> v2(4);
  
  //Vector Iterators
  v.begin();// 벡터 시작점의 주소 값 반환
  v.end();// 벡터의 끝부분+1 주소값 반환 
  v.rbegin();// reverse begin , 벡터의 끝점의 주소 값 반환 
  v.rend();// reverse end, 벡터의 시작-1 주소값 반환
  
  //Vector Element access
  v.at(i); // 벡터의 i번째 요소에 접근, 범위검사 (범위 밖에 접근 시 예외처리)
  v[i]; // 벡터의 i번쨰 요소에 접근, 범위검사 x
  v.front(); // 벡터의 첫번째 요소 접근
  v.back(); // 벡터의 마지막 요소 접근
  
  //Vector Element Insert
  v.push_back(i); // v.end()위치에 요소를 추가
  v.emplace_back() // v.end()위치에 요소를 추가 (move로 인해 복사생성자 X)
    
  v.insert(&v1, v2 );// 원하는 위치의 주소값에 요소 삽입, insert는 삽입위치에 요소를 삽입하고 이후의 요소를 뒤로 한칸씩 이동시킨다.
  v.emplace(&v1, v2);// 원하는 위치의 주소값을 원하는 요소로 대체한다, emplace는 새로운 요소를 벡터의 지정된 위치에 생성한다
  
  // insert는 삽입위치에 요소를 삽입하고 이후의 요소를 뒤로 한칸씩 이동시킨다.
  // emplace는 새로운 요소를 벡터의 지정된 위치에 생성한다 (원래의 요소는 사라지지만 이후의 요소들은 그대로있게된다.)
  
  v.pop_back(); // v.back()위치에 요소를 제거
  v.erase(index); // 사용자가 원하는 index의 요소를 제거
  v.erase(start, end); // 사용자가 원하는 범위의 요소를 지운다.
  v.clear(); // 벡터의 모든 요소를 지운다.
  v.resize(value); // 벡터의 사이즈를 조정한다. (이때 추가되는 요소는 0으로 초기화한다, 작아지는경우 뒤쪽요소가 제거된다(소멸자 호출))
  v.swap(v2); // 벡터끼리 스왑한다.
  
  //Vector Capacity
  v.empty(); //벡터가 비었으면 true
  v.size(); //벡터의 크기 반환
  v.capacity(); // heap공간에 할당된 벡터의 실제크기(최대크기)반환
  v.max_size();// system 상에서 만들어 질수있는 최대 크기 반환
  v.reserve(i); // 벡터의 capacity의 크기를 설정
  v.shrink_to_fit();// capacity의 크기를 벡터의 실제크기와 맞춘다.
  
  //Vector의 크기가 capacity()의 크기를 초과해버리면
  //reallocate(재할당)이 발생하게 되어 모든 값들을 새로운 메모리 공간에 복사한 후 기존 벡터를 파괴한다
  //복사생성자가 발생하게된다. v.reserve()를 사용해 재할당을 방지할수 있다.
  //clear()로 벡터 값들을 지우게되면 capacity는 남게된다 이때
  //vector<int>().swap(v); 를 통해 크기가 0인 빈백터와 swap을 하여 capacity를 없앨수 있다.
  //capacity는 중괄호를 벗어날때 자동으로 해제가 된다. 
  
}
