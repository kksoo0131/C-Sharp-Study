// 삽입 정렬
// 선택한 원소의 자리를 만들어준 후 삽입하는 정렬

// 최악의 경우 O(N^2) 최선의 경우 O(N)의 시간복잡도를 가지므로
// 시간복잡도는 O(N^2)이다.

// 1. temp에 선택한 원소를, prev에 선택원소의 바로 앞 위치를 저장
// 2. 선택한 값과 앞에 값들을 비교해서 더큰값들은 한칸씩 뒤로 밀어준다.
// 3. 찾은 자리에 선택한 값을 넣어준다.
#include <iostream>
using namespace std;
int main() {
	int arr[10] = { 2,5,6,3,4,0,1,7,8,9 };

	for (int i = 1; i < 10; i++) {
		int temp = arr[i];
		int prev = i - 1;

		while (prev >= 0 && arr[prev] > temp) {
			arr[prev + 1] = arr[prev];
			prev--;
		}
		
		arr[prev + 1] = temp;
	}

	for (int i : arr) {
		cout << i << " ";
	}
}
// 출력 : 0 1 2 3 4 5 6 7 8 9
