## 이분 탐색 (BinarySearch)
탐색 범위를 두 부분으로 두 부분으로 분할하면서 찾는 방식

내가 찾는 값이 기준에서 왼쪽범위에 있는지 오른쪽 범위에 있는지를 판단하여 범위를 줄여나가며 값을 찾는다.

정렬된 데이터에서 사용가능하다.

```cpp
int arr[10]{ 1, 2, 3, 4, 5, 6, 7, 8 ,9 , 10 };
int goal = 10;

int BinarySearch(int start, int end) {
	while (start <= end) {
		int mid = (start + end) / 2;

		if (arr[mid] == goal)
			return mid;
		else if (arr[mid] > goal) {
			end = mid - 1;
		}
		else if (arr[mid] < goal) {
			start = mid + 1;
		}
	}

}
int main() {
	cout << BinarySearch(0, 10);
  // 찾고자 하는 값의 위치를 출력
}
```
