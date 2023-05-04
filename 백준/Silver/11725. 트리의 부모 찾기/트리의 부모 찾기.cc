#include <iostream>
#include <vector>
using namespace std;

// 연결된 노드중 나보다 1에 가까운게 내부모임
// 1부터 한번 순회하면서 깊이를 지정해준다?

vector<int> arr[100001];
int depth[100001];

void dfs(int N, int d) {
	depth[N] = d;

	for (int i : arr[N]) {
		if (depth[i] == 0) {
			dfs(i, d + 1);
		}
	}

}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0), cout.tie(0);
	int N; 
	cin >> N;

	

	for (int i = 1; i <= N - 1; i++) {
		int a, b;
		cin >> a >> b;
		arr[a].push_back(b);
		arr[b].push_back(a);
	}

	dfs(1, 1);
	for (int i = 2; i <= N; i++) {
		int answer = i;
		for (int j : arr[i]) {
			if (depth[j] < depth[answer]) {
				answer = j;
			}
		}

		cout << answer << '\n';
	}

}


//1 6 3 5
//4 7
//2