// 병합 정렬
// 분할 정복 방법을 통해 주어진 배열을 정렬한다.
// (문제를 작은 2개의 문제로 분리하고 각각을 해결한 다음, 결과를 모으는 방법)
// 
// 요소를 쪼갠 후, 다시 합병 시키면서 정렬해나가는 방식

// 항상 O(nlogn)의 시간복잡도를 가진다.

#include <iostream>
#include <vector>

using namespace std;
void merge(vector<int>& arr, int left,int mid,int right) {
	vector<int> tmp(right - left + 1);
	int tmp_left = left, tmp_right = mid + 1, k = 0;

	// 정렬된 두배열을 앞에서 부터 비교하면서 정렬을 유지하며 합친다.
	while (tmp_left <= mid && tmp_right <= right) {
		if (arr[tmp_left] <= arr[tmp_right])
			tmp[k++] = arr[tmp_left++];
		else
			tmp[k++] = arr[tmp_right++];
	}

	// 남은 한쪽배열을 다 추가해준다.

	while (tmp_left <= mid)
		tmp[k++] = arr[tmp_left++];

	while (tmp_right <= right)
		tmp[k++] = arr[tmp_right++];

	// tmp에 합쳐진 배열을 arr에 복사해준다.
	for (int i = left; i <= right; i++) {
		arr[i] = tmp[i - left];
	}
}
void mergeSort(vector<int>& arr, int left, int right) {

	if (left < right) {
		int mid = (left + right) / 2;

		mergeSort(arr, left, mid);
		mergeSort(arr, mid + 1, right);

		merge(arr, left, mid, right);
	}
	 
}

int main() {
	vector<int> arr = { 2,5,1,7,3,8,6,4,9 };
	mergeSort(arr, 0, arr.size() - 1);

	for (int i : arr) {
		cout << i << " ";
	}
}
