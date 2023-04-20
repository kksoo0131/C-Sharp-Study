#include <iostream>
#include <string>
#include<vector>

using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	string N;
	cin >> N;
	vector<int> list(10);
	for (char c : N) {
		int idx = c - 48;
		list[idx]++;
	}

	while (!list.empty()) {
		int temp = list.back();
		while (temp--) {
			cout << list.size()-1;
		}
		list.pop_back();
	}
	
}