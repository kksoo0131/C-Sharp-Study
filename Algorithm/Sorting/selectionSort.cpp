// 선택 정렬 
// 자리를 선택해서 해당자리에 어떤원소를 넣을지 선택하는 정렬
// 시간복잡도는 O(N^2)

//1. 주어진 배열 중에 최소값을 찾는다.
//2. 그 값을 맨 앞에 위치한 값과 교체한다.
//3. 맨 앞을 뺀 나머지 배열을 같은 방법으로 반복한다.

#include <iostream>
using namespace std;
int main() {
    int arr[10] = { 3,5,2,5,6,7,8,4,9,0 };

    for (int i = 0; i < 10; i++) {
        int min = i;
        for (int j = i + 1; j < 10; j++) {
            if (arr[min] > arr[j]) min = j;
        }
        swap(arr[i], arr[min]);
    }

    for (int i : arr) {
        cout << i << " ";
    }

}

// 출력 : 0 2 3 4 5 5 6 7 8  9
