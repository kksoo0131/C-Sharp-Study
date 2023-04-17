#include <iostream>
#include <deque>
#include <algorithm>
using namespace std;
int main() {
	cin.tie(0), cout.tie(0), ios::sync_with_stdio(false);
	int T;
	cin >> T;
	
	while (T--) {
		int N, M;
		cin >> N >> M;
		deque<int> dq;
		
		for (int i = 1; i <= N; i++) {
			int temp;
			cin >> temp;
			dq.push_back(temp);
		}

		while (true) {
			int max_val = *max_element(dq.begin(), dq.end());
			int front = dq.front();
			dq.pop_front();

			if (front != max_val) {
				dq.push_back(front);
			}
			else {
				if (M == 0) {
					cout << N - dq.size() << '\n';
					break;
				}
			}

			M--;
			if (M < 0) {
				M = dq.size() - 1;
			}
		}
		


	}
}