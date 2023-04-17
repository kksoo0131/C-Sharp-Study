#include <iostream>
#include <deque>
using namespace std;
int main() {
	cin.tie(0), cout.tie(0), ios::sync_with_stdio(false);
	int N, K;
	cin >> N >> K;
	deque<int> dq;

	for (int i = 1; i <= N; i++) {
		dq.push_back(i);
	}

	cout << "<";

	while (dq.size() > 1) {

		for (int i = 1; i < K; i++) {
			dq.push_back(dq.front());
			dq.pop_front();
		}
		cout << dq.front() << ", ";
		dq.pop_front();
		
	}

	cout << dq.front() << ">";
}