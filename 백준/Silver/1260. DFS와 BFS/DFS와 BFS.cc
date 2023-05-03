#include <iostream>
#include <vector>
#include <deque>
#include <set>

using namespace std;

vector<set<int>> arr(1001);
vector<bool> check(1001, true);
vector<bool> check2(1001, true);

void DFS(int V) {
	if (check[V]) {
		cout << V << " ";
		check[V] = false;
		for (int i : arr[V]) {
			DFS(i);
		}
	}
}

void BFS(int V) {
	deque<int> dq;
	dq.push_back(V);

	while (!dq.empty()) {
		int temp = dq.front();
		dq.pop_front();

		if (check2[temp]) {
			cout << temp << " ";
			check2[temp] = false;
			for (int i : arr[temp]) {
				dq.push_back(i);
			}
		}
	}
}


int main() {
	int N, M, V;
	cin >> N >> M >> V;

	for (int i = 0; i < M; i++) {
		int temp[2];
		cin >> temp[0] >> temp[1];
		arr[temp[0]].insert(temp[1]);
		arr[temp[1]].insert(temp[0]);
	}

	DFS(V);
	cout << "\n";
	BFS(V);
}