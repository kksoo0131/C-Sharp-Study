#include <iostream>
#include <algorithm>
#include <deque>

using namespace std;

int main() {

	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N;
	cin >> N;

	deque<int> arr(N);
	deque<int> answer(2);

	for (int i = 0; i < N; i++) {
		cin >> arr[i];
	}

	sort(arr.begin(), arr.end());

	int start = 0;
	int end = N - 1;
	int minValue = 2000000001;

	while (start < end) {
		int sum = arr[start] + arr[end];

		if (minValue > abs(sum)) {
			minValue = abs(sum);
			answer[0] = arr[start];
			answer[1] = arr[end];
		}


		if (sum == 0) {
			break;
		}
		else if (sum < 0) {
			start++;
		}
		else {
			end--;
		}
	}

	cout << answer[0] << " " << answer[1];
}