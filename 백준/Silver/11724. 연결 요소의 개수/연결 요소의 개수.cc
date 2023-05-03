#include <iostream>
#include <set>
#include <vector>
using namespace std;


int N, M, answer = 0;
vector<set<int>> vec;
vector<bool> check;

void DFS(int i) {
	if (check[i]) {
		check[i] = false;
		for (int i : vec[i]) {
			DFS(i);
		}
	}
}

int main() {
	cin >> N >> M;
	vec.resize(N+1);
	check.resize(N+1, true);

	for (int i = 1; i <= M; i++) {
		int temp[2];
		cin >> temp[0] >> temp[1];
		vec[temp[0]].insert(temp[1]);
		vec[temp[1]].insert(temp[0]);
	}

	for (int i = 1; i <= N; i++) {
		if (check[i]) {
			answer++; // 첫입장때만 늘려줌
			DFS(i);
		}
	}

	cout << answer;
}