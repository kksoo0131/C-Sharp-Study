#include <iostream>
#include <string>
#include <vector>


int main() {
    std::ios_base::sync_with_stdio(0);
    std::cin.tie(0), std::cout.tie(0);
	std::string str;
	std::cin >> str;
	std::vector<char> left(str.length());
	std::vector<char> right;
//cursor를 기준으로 left와 right 두개의 스택으로 나누어 생각
	int M;
	std::cin >> M;
	for (int i = 0; i < left.size(); i++) {
		left[i] = str[i];
	}

	for (int i = 0; i < M; i++) {
		std::cin >> str;
		if (str == "L" && !left.empty()) {
			right.push_back(left.back());
			left.pop_back();
		}
		else if (str == "D" && !right.empty()) {
			left.push_back(right.back());
			right.pop_back();
		}
		else if (str == "B" && !left.empty()) {
			left.pop_back();
		}
		else if (str == "P"){
			char temp;
			std::cin >> temp;
			left.push_back(temp);
		}
	}

	int move = right.size();
	for (int i = 0; i < move; i++) {
		left.push_back(right.back());
		right.pop_back();
	}

	for (char c : left) {
		std::cout << c;
	}
	


}