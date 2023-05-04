
#include <iostream>
#include <vector>
using namespace std;

int list[10001]; // 이미 초대했다면 1
vector<int> friends[501]; 
int answer = 0;


int main() {
	int n, m;
	cin >> n >> m;
	for (int i = 0; i < m; i++) {
		int a, b;
		cin >> a >> b;
		friends[a].push_back(b); 
		friends[b].push_back(a);
	}

	list[1] = 1;
	for (int i : friends[1]) {

		if (list[i] == 0) {
			list[i] = 1;
			answer++;
		}

		for (int j : friends[i]) {
			if (list[j] == 0) {
				list[j] = 1;
				answer++;
			}
		}
	}

	cout << answer;
}

 