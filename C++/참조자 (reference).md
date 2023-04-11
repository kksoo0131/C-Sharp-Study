## Reference

- 이미 선언된 변수 또는 객체의 별칭(alias)을 만들어주는 것, 변수 또는 객체와 동일한 메모리 주소를 가리킨다.

- 레퍼런스는 NULL일수 없기 때문에 선언할때 반드시 초기화 해주어야 하고, 가리키는 변수 또는 객체를 변경할수 없다.

- 래퍼런스의 초기화 후 지역변수가 사라져버리는 경우를 "댕글링 래퍼런스" 라고 하고 오류가 발생하기 떄문에 주의 해야한다.


``` cpp
#include <iostream>

int change_val(int& p) {
	p = 3;
	return 0;
}

int main() {
	int number = 5;

	std::cout << number << std::endl;
	change_val(number);
  
  // change_val(number)를 호출하는 동시에 int& p = number가 되고 해당 함수안에서 p는 number의 새로운 별명이 된다. 
  
  // change_val 함수 안에서 p의 값을 변경하는 것은 외부에 있는 변수인 number의 값을 변경하는 것과 같은 작업이된다.
  
  
	std::cout << number << std::endl;
}
```
- 레퍼런스의 레퍼런스, 레퍼런스의 배열, 레퍼런스의 포인터는 존재할 수 없다.
- 레퍼런스는 특별한 경우 이외에는 메모리 상에서 공간을 차지 않기 때문이다.
- 그와 반대인 배열들의 래퍼런스가 불가능 한 것은 아니다.

``` cpp
#include <iostream>
int main()
{
  // int& arr[2] = {a,b}; 는 불가능 = int형변수의 레퍼런스의 배열을 만들려고 했기때문
  int arr[3] = [1,2,3};
  int (&ref)[3] = arr; // int형 배열의 레퍼런스를 만들었기에 가능, 하지만 반드시 배열의 크기를 명시하고 크기가 맞아야된다.
}
```

- 레퍼런스를 리턴하는 경우의 장점
- 그냥 변수를 리턴하면 값을 복사해야되서 크기가 커질수록 시간이 오래걸리지만
- 해당 변수를 가르키는 포인터나 레퍼런스를 리턴한다면 크기와 상관없이 주소 한번의 복사로 매우 빠르게 끝낼수 있다. 

``` cpp
int& function(int& a) {
  a = 5;
  return a;
}

int main() {
  int b = 2;
  int c = function(b);
  return 0;
}
```
