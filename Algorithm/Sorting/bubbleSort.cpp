//bubbleSort
//서로 인접한 두원소를 검사하여 정렬하는 알고리즘으로 O(n^2)이다.

// n 크기의 배열에서 정렬을 n번수행한다.
// 정렬을 수행할때마다 마지막 데이터가 정렬대상에서 제외된다.

#include <iostream>
using namespace std;

void swap(int& a, int& b) {
    if (a > b) {
        int temp = b;
        b = a;
        a = temp;
    }
}

int main(){
  int arr[10] = {9,8,7,6,5,4,3,2,1,0};
  
  for (int i =1; i<= 10; i++){
    for (int j=0; j < 10-i; j++){
      if (arr[j] > arr[j+1]){
        swap(arr[j], arr[j+1);
      }
    }
  }
  
  for (int i : arr) {
        cout << i << " ";
    }
}

// 출력:
// 0 1 2 3 4 5 6 7 8 9
