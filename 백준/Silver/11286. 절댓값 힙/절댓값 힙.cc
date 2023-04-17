#include <iostream>
#include <queue>
using namespace std;
bool compare(int x, int y) {
	if (abs(x) == abs(y))
		return x > y;
	return abs(x) > abs(y);
}
int main() {
	cin.tie(0), cout.tie(0), ios::sync_with_stdio(false);
	int N;
	cin >> N;
	priority_queue<int, vector<int>, decltype(&compare) > pq(&compare);

	for (int i = 1; i <= N; i++) {
		int temp;
		cin >> temp;

		if (temp == 0) {
			if (pq.empty())
				cout << 0 << '\n';
			else {
				cout << pq.top() << '\n';
				pq.pop();
			}

		}
		else {
			pq.push(temp);
		}
	}
}