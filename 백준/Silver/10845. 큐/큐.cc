#include <iostream>
#include <deque>
#include <string>
using namespace std;
int main() {
    ios::sync_with_stdio(false);
    cin.tie(0), cout.tie(0);
	int N;
	cin >> N;
	string str;
	deque<int> queue;
	for (int i = 0; i < N; i++) {
		cin >> str;
		if (str == "push") {
			int temp;
			cin >> temp;
			queue.push_back(temp);
		}
		else if (str == "pop") {
			if (queue.empty()) {
				cout << -1 << '\n';
				continue;
			}
			cout << queue.front()<< '\n';
			queue.pop_front();
		}
		else if (str == "size") {
			cout << queue.size() << '\n';
		}
		else if (str == "empty") {
			cout << queue.empty() << '\n';
		}
		else if (str == "front") {
			if (queue.empty()) {
				cout << -1 << '\n';
				continue;
			}
			cout << queue.front() << '\n';
		}
		else if (str == "back") {
			if (queue.empty()) {
				cout << -1 << '\n';
				continue;
			}
			cout << queue.back() << '\n';
		}
	}
}