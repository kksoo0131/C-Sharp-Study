#include <iostream>
#include <vector>

int main() {
	std::string str;
	std::cin >> str;
	std::vector<int> stack;
	int answer = 0;

	for (int i = 0; i < str.length(); i++) {
		if (str[i] == '(') {
			stack.push_back(i);
		}
		else if (str[i] == ')') {
			if (i - stack.back() == 1) {
				// 레이져이기때문에 
				stack.pop_back();
				answer += stack.size(); 
			}
			else {
				stack.pop_back();
				answer += 1;
			}
			
		}
	}

	std::cout << answer;
}