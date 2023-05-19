//집의 좌표 x
//공유기 C개 설치
//가장 가까운 공유기의 거리가 최대가 되도록 해라.
// == 모든 공유기들의 간격이 최대한 일정하게 되도록
// 이분탐색으로 "간격"을 찾아야함

// 간격을 정하고
// 해당간격이 조건을 만족하는지 확인한다.

#include <iostream>
#include <algorithm>
#include <vector>
using namespace std;

int N, C;
vector<int> position;

int ConditionalFunction(int mid_dist) {
	// 모든 공유기를 기준간격 이상으로 설치했을때
	// 몇개의 공유기를 설치할수 있는지 확인

	int installed = 1; // 첫번째 공유기는 이미 설치되어 있음
	int start = position[0]; // 첫번쨰 공유기의 위치 (기준 공유기)

	for (int i = 1; i < N; i++) {
		if (position[i] - start >= mid_dist) {
			installed++;
			start = position[i];
			// 해당 공유기가 기준간격 이상이라면 설치를 하고
			// 기준 공유기를 변경
		}
	}

	return installed;

}

int BinarySearch() {

	int l_dist = 0; // 첫번쨰 공유기 ~ 첫번째 공유기까지의 거리
	int r_dist = position[N - 1] - position[0];// 첫번째 공유기 ~ 마지막 공유기까지의 거리

	int answer = 0;

	while (l_dist <= r_dist) {
		int mid_dist = (l_dist+ r_dist)/2; // 기준 간격

		if (ConditionalFunction(mid_dist) >= C){
			answer = mid_dist;
			l_dist = mid_dist + 1; // 다음 탐색은 이것보다 큰 기준을 선택
		}
		else {
			r_dist = mid_dist - 1; // 다음 탐색은 이것보다 작은 기준을 선택
		}
	}

	return answer;

}

int main() {

	cin >> N >> C;

	int temp;
	for (int i = 0; i < N; i++) {
		cin >> temp;
		position.push_back(temp);
	}
	
	sort(position.begin(), position.end());

	cout << BinarySearch();
}