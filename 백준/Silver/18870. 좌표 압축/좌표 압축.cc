#include <iostream>
#include <string>
#include<vector>
#include<map>
#include <algorithm>

using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N ;
	cin >> N;
	
	vector<int> v1(N);
	map<int, vector<int>> m;

	for (int i = 0; i < N; i++) {
		int temp;
		cin >> temp;
		v1[i] = temp;
		m[temp].push_back(i);
	}

	int num = 0;
	for (pair<int, vector<int>> p : m) {
		for (int i : p.second) {
			v1[i] = num;
		}
		num++;
	}

	for (int i : v1) {
		cout << i << " ";
	}

	// 입력받고

	// map에 인덱스를 저장할까? 수마다
	// key랑 인덱스들을 저장해서
	// key 순으로 돌면서 인덱스를 변경
	

}