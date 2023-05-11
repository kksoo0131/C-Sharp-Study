// 퀵 정렬
// 분할 정복 방법을 통해 주어진 배열을 정렬한다.
// (문제를 작은 2개의 문제로 분리하고 각각을 해결한 다음, 결과를 모으는 방법)

// 1. 하나의 원소를 골라 pivot이라고 한다.
// 2. pivot보다 작으면 왼쪽, 크면 오른쪽으로 보내서 pivot의 자리를 찾아준다.
// 3. pivot의 왼쪽과 오른쪽으로 배열을 나눈다.
// 4. 나눠진 배열로 재귀한다.

// 퀵정렬은 피벗이 최소나 최대값이 되어서 배열이 나누어지지 않을떄 
// 즉, 오름차순이거나 내림차순 "정렬 되어있다면" O(N^2)의 시간복잡도를 가진다.
// 최선의 경우 O(nlog2n)의 시간복잡도를 가진다.

#include <iostream>
using namespace std;

int partition(int (&arr)[], int left, int right) {
	// left,right로 배열이 분할되어있다.
	int pivot = arr[left];
	int tmp_left = left, tmp_right = right;

	// 왼쪽 오른쪽이 교차될때까지 반복
	while (tmp_left < tmp_right) {
		// 오른쪽에서 pivot보다 작은값의 인덱스
		while (pivot < arr[tmp_right]) {
			tmp_right--;
		}
		// 왼쪽에서 pivot 보다 큰값의 인덱스
		while (tmp_left < tmp_right && pivot >= arr[tmp_left]) {
			tmp_left++;
		}

		// 오른쪽에서 pviot보다 작은값과 왼쪽에서 pivot보다 큰값을 교환
		swap(arr[tmp_left], arr[tmp_right]);
	}
	// 오른쪽 왼쪽이 교차되는 지점과 pivot을 교환
	arr[left] = arr[tmp_left];
	arr[tmp_left] = pivot;

	return tmp_left;
}


void quickSort(int (&arr)[], int left, int right) {
	// 왼쪽 오른쪽이 교차될때까지 재귀
	if (left >= right) return;

	for (int i = 0; i < 9; i++) {
		cout << arr[i] << " ";
	}
	cout << '\n';

	// 피벗이 들어갈 자리를 찾아주고
	int pivot = partition(arr, left, right);

	quickSort(arr, left, pivot - 1);
	quickSort(arr, pivot + 1, right);
}

int main() {
	int arr[9] = { 5,4, 9, 8, 1, 2, 6, 7, 0 };

	quickSort(arr, 0, 8);

	for (int i : arr) {
		cout << i << " ";
	}
}
