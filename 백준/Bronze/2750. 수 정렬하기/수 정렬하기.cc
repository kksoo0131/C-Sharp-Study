#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N;
	cin >> N;

	vector<int> arr(N);
	while (N--) {
		cin >> arr[N];
	}

	sort(arr.begin(), arr.end());

	for (int i : arr) {
		cout << i << '\n';
	}
}