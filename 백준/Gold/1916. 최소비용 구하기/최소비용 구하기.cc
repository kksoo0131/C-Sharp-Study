#include <iostream>
#include <deque>
using namespace std;

class Bus {
public:
	int destination;
	int cost;
	Bus() : destination(0), cost(0) {};
};

int N, M, S, E;
deque<Bus> arr[1001];
int visited[1001];
int dist[1001];
const int MAX_VALUE = 100000001;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);
	cin >> N;
	cin >> M;

	for (int i = 0; i < M; i++) {
		int temp;
		cin >> temp;
		arr[temp].push_back(Bus());
		cin >> arr[temp].back().destination;
		cin >> arr[temp].back().cost;
		
	}
	cin >> S;
	cin >> E;

	deque<Bus> dq;
	fill(visited, visited + 1001, 0);
	fill(dist, dist + 1001, MAX_VALUE);
	visited[S] = 1;
	dist[S] = 0;

	for (Bus b : arr[S]) {
		if (visited[b.destination] == 0) {
			if (dist[b.destination] > b.cost)
				dist[b.destination] = b.cost;
				
		}	
	}
	
	while (true) {
		// 모르는 곳의 거리는 무한대이기 떄문에
		// 아는 정보중에서 거리가 최소인 정점을 찾는다.
		int minDist = MAX_VALUE;
		int minx = -1;
		for (int i = 1; i <= N; i++) {
			if (visited[i] == 0 && dist[i] != MAX_VALUE) {
				if (dist[i] < minDist) {
					minDist = dist[i];
					minx = i;
				}
			}
		}

		if (minx == -1) {
			break;
		}

		// 최소인 점을 찾아서
		// 최소인 점에서 갈수있는 최단거리들을 갱신한다.
		visited[minx] = 1;
		for (Bus b : arr[minx]) {
			if (visited[b.destination] == 0) {
				if (dist[b.destination] > dist[minx] + b.cost) {
					dist[b.destination] = dist[minx] + b.cost;
				}
			}

		}
	}
	
	cout << dist[E];
}