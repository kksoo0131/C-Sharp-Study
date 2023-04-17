#include <iostream>
#include <queue>
using namespace std;
int main() {
	cin.tie(0), cout.tie(0), ios::sync_with_stdio(false);
	int N;
	cin >> N;
	priority_queue<int, vector<int>, greater<int> > min_heap;

	for (int i = 1; i <= N; i++) {
		int temp;
		cin >> temp;

		if (temp == 0) {
			if (min_heap.empty())
				cout << 0 << '\n';
			else {
				cout << min_heap.top() << '\n';
				min_heap.pop();
			}

		}
		else {
			min_heap.push(temp);
		}
	}
}