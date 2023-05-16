// 병합 정렬
// 분할 정복 방법을 통해 주어진 배열을 정렬한다.
// (문제를 작은 2개의 문제로 분리하고 각각을 해결한 다음, 결과를 모으는 방법)
// 
// 요소를 쪼갠 후, 다시 합병 시키면서 정렬해나가는 방식

// 항상 O(nlogn)의 시간복잡도를 가진다.

#include <iostream>
#include <vector>
using namespace std;

void mergeSort(vector<int>& arr, int start,int end) {

	if (start < end) {
		int mid = (start + end) / 2;
		mergeSort(arr, start, mid);
		mergeSort(arr, mid + 1, end);


		int left = start;
		int right = mid+1;
		vector<int> temp;

		while (left <= mid && right <= end) {
			if (arr[left] <= arr[right]) {
				temp.push_back(arr[left++]);
			}
			else {
				temp.push_back(arr[right++]);
			}
		}

		while (left <= mid) {
			temp.push_back(arr[left++]);
		}

		while (right <= end) {
			temp.push_back(arr[right++]);
		}

		for (int i = 0; i < temp.size(); i++) {
			arr[i + start] = temp[i];
		}
	}
	
}
int main() {
	vector<int> arr = {9,8,7,6,5,4,3,2,1,0};

	mergeSort(arr, 0,9);

	for (int i : arr) {
		cout << i << " ";
	}
}
