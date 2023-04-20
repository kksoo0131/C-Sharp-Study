#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N;
	cin >> N;

	// 10,000,000개의 수를 저장하면 메모리 초과가발생
	// 수의 최대값은 10000이므로 
	// 배열에 수의 갯수를 저장해야됨
	vector<int> arr(10001,0);
	while (N--) {
		int temp;
		cin >> temp;
		arr[temp]++;
	}

	for (int i = 1; i < arr.size(); i++) {
		for (int j = 0; j < arr[i]; j++) {
			cout << i << '\n';
		}
	}
}