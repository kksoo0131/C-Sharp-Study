#include <iostream>
#include <deque>
#include <string>
using namespace std;
int main() {
	cin.tie(0), cout.tie(0), ios::sync_with_stdio(false);

	int N;
	cin >> N;
	
	deque<int> deque;

	for (int i = 1; i <= N; i++) {
		deque.push_front(i);
	}

	while (deque.size() > 1) {
		deque.pop_back();
		deque.push_front(deque.back());
		deque.pop_back();
	}

	cout << deque[0];

	
}