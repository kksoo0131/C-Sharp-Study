#include <iostream>
#include <vector>
using namespace std;


int N, M, answer = 0;
vector<int> vec[1001];//아 벡터 배열;;;;
vector<bool> check(1001,true);

void DFS(int N) {
	
		check[N] = false;
		for (int i : vec[N]) {
			if (check[i]) { DFS(i); }		
		}
	
}

int main() {
	cin >> N >> M;

	for (int i = 1; i <= M; i++) {
		int start, end;
		cin >> start >> end;
		vec[start].push_back(end);
		vec[end].push_back(start);
	}

	for (int i = 1; i <= N; i++) {
		if (check[i]) {
			answer++; // 첫입장때만 늘려줌
			DFS(i);
		}
	}

	cout << answer;
}