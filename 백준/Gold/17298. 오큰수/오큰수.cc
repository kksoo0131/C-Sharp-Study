#include <iostream>
#include <vector>
using namespace std;
int main() {
	int N;
	cin >> N;
	vector<int> stack;
	vector<int> num(N);
	vector<int> answer(N,-1);

	for (int i = 0; i < N; i++) {
		cin >> num[i];
	}

	for (int i = N - 1; i >= 0; i--) {
		// 스택을 오름차순으로 유지시킨다.
		while(!stack.empty() && stack.back() <= num[i])
			stack.pop_back();

		if (stack.empty()) answer[i] = -1;
		else answer[i] = stack.back();

		stack.push_back(num[i]);


	}
	
	for (int i : answer) {
		cout << i << " ";
	}
	
}