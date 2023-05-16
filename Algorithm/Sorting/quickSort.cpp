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
#include <vector>
using namespace std;

void quickSort(vector<int>& arr, int start, int end) {
	
	if (start >= end) return;

	int pivot = arr[start]; // 일단은 가장 왼쪽을 피벗으로 지정
	int left = start; // 왼쪽 인덱스
	int right = end; // 오른쪽 인덱스

	while (left < right) { // 피벗의 자리를 찾을때까지 반복

		//피벗의 오른쪽에는 피벗보다 큰수만
		//피벗의 왼쪽에는 피벗보다 작은수만 모이게된다.

		while (pivot < arr[right]) { right--; }// 오른쪽에서 피벗보다 작은걸 찾는다.

		while (left < right && pivot >= arr[left]) { left++; }// 왼쪽에서 피벗보다 큰걸 찾는다.

		swap(arr[right], arr[left]); // 둘의 자리를 교환
	}
	// left == right일것이고
	// 이 인덱스는 처음에 정한 pivot의 자리일것이다.

	arr[start] = arr[left];
	arr[left] = pivot;
	pivot = left;
	// 피벗에 인덱스를 넣어주고 피벗을 기준으로 배열을 나누어서 계속 정렬한다.

	quickSort(arr, start, pivot - 1);
	quickSort(arr, pivot + 1, end);
	


}
int main() {
	vector<int> arr = {9,8,7,6,5,4,3,2,1,0};

	quickSort(arr, 0, 9);

	for (int i : arr) {
		cout << i << " ";
	}
}
