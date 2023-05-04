
//BFS 가장 빠른시간 찾기

// 1. 1칸이동
// 2. 현재 위치 x2로 이동

// 위치 X에 가는방법은 X/2 에서 순간이동을 하거나
// X-1에서 한칸 이동하거나
// X+1에서 한칸 이동해야된다.
// X+1이 있어서 DP가 아니라 BFS인듯?


#include <iostream>
#include <deque>
using namespace std;

int visited[100001];
deque<int> position;

int main() {
	int N, K;
	int answer = 0;
	

	cin >> N >> K;
	position.push_back(N);

	visited[N] = 1;

	while (!position.empty()) {
		int current = position.front();
		position.pop_front();

		if (current == K) {
			answer = visited[current];
			break;
		}
		
		if (current-1 >= 0 && visited[current - 1] == 0) {
			position.push_back(current - 1);
			visited[current - 1] = visited[current] + 1;
		}

		if (current+1 <= 100000 && visited[current + 1] == 0) {
			position.push_back(current + 1);
			visited[current + 1] = visited[current] + 1;
		}

		if (current * 2 <= 100000 && visited[current * 2] == 0) {
			position.push_back(current * 2);
			visited[current *2] = visited[current] + 1;
		}
	}

	cout << answer-1;
}
