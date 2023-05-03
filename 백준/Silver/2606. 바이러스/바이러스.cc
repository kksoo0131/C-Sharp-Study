#include <iostream>
#include <vector>
using namespace std;
vector<int> arr[101];
bool visited[101];
int answer = 0;

void dfs(int N) {
	visited[N] = true;
	
	for (int i : arr[N]) {
		if (!visited[i]) {
			dfs(i);
			answer++;
		}
	}
}

int main() {
	int N, M, a, b;
	cin >> N >> M;

	for (int i = 1; i <= M; i++) {
		cin >> a >> b;
		arr[a].push_back(b);
		arr[b].push_back(a);
	}

	dfs(1);

	cout << answer;
}