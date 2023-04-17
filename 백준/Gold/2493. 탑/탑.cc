#include <iostream>
#include <vector>
using namespace std;
int main() {
	int N;
	cin >> N;
	vector<int> stack(N);
	vector<vector<int>> sign;
	vector<int> answer(N, 0);

	for (int i = 0; i < N; i++) {
		cin >> stack[i];
	}

	while (stack.size() > 1 ) {

		if (sign.empty()) {
			vector<int> temp { stack.back(), (int)stack.size() - 1 };
			sign.push_back(temp);
			stack.pop_back();
			
		}

		if (stack.back() > sign.back().front()) {
			answer[sign.back().back()] = stack.size();
			sign.pop_back();
		}
		else {
			vector<int> temp{ stack.back(), (int)stack.size() - 1 };
			sign.push_back(temp);
			stack.pop_back();
		}
		
	
	}

	// 마지막 남은 비교 처리
	for (vector<int> i : sign) {
		if (stack.back() > i.front()) {
			answer[i.back()] = 1;
		}
	}

	for (int i : answer) {
		cout << i << " ";
	}
}