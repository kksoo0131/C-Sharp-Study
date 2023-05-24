//그래프를 입력 받아서
//DFS와 BFS로 출력해라

#include <iostream>
#include <deque>
#include <algorithm>

using namespace std;

int N, M, V;

deque<int>* arr;
int* visited;

void DFS(int n) {
	
	visited[n] = 1;
	cout << n << " ";

	for (int i = 0; i < arr[n].size(); i++) {
		int temp = arr[n][i];

		if (visited[temp] == 0)
			DFS(temp);
		
	}
}

void BFS(int n) {
	deque<int> dq;
	dq.push_back(n);
	visited[n] = 1;

	while (!dq.empty()) {
		int index = dq.front();
		dq.pop_front();

		cout << index << " ";

		for (int i = 0; i < arr[index].size(); i++) {
			int temp = arr[index][i];

			if (visited[temp] == 0) {
				dq.push_back(temp);
				visited[temp] = 1;
			}
		}


	}
}
int main() {

	cin >> N >> M >> V;

	arr = new deque<int>[N+1];

	for (int i = 0; i < M; i++) {
		int index, value;
		cin >> index >> value;
		arr[index].push_back(value);
		arr[value].push_back(index);
	}

	for (int i = 0; i < N + 1; i++) {
		sort(arr[i].begin(), arr[i].end());
	}

	visited = new int[N+1];
	fill(visited, visited + N+1, 0);
	DFS(V);

	cout << '\n';

	delete[] visited;
	visited = new int[N + 1];
	fill(visited, visited + N + 1, 0);
	BFS(V);

}