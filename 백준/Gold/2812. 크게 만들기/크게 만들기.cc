#include <iostream>
#include <vector>
#include <string>
using namespace std;
int main() {
	int n, k;
	cin >> n >> k;
	string str;
	vector<int> nums(n);
	vector<int> stack;

	cin >> str;
	for (int i = 0; i < n; i++) {
		nums[i] = str[i] -48;
	}

	//스택을 오름차순으로 만든다.
	// k 번의 횟수 제한에 유의

	for (int i = 0; i < n; i++) {
		//전체를 순환
		while (!stack.empty() && k  && stack.back() < nums[i]) {
			// 스택의 top이 이번선택한 수보다 작다면 제거
			k--;
			stack.pop_back();
		}
		stack.push_back(nums[i]);
		// 이번선택한 수를  stack에 넣어줌

	}

	// 마지막수가 제거할수였다면
	// stack에 들어가게되고 k에는 1이남게됨
	for (int i = 0; i < stack.size() -k; i++) {
		cout << stack[i];
	}
	
}