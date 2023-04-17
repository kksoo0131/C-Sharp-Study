#include <iostream>
#include <vector>
#include <string>


int main() {
	int N;
	std::cin >> N;
	std::vector<int> tempStack(N);
	std::vector<int> resultStack(N);
	int index = 1;
	std::string str = "";

	for (int i = 0; i < N; i++) {
		int number;
		std::cin >> number;
		while (number >= index) {
			tempStack.push_back(index++);
			str +=  "+\n";
		}

		if (tempStack.back() == number) {
			resultStack.push_back(tempStack.back());
			tempStack.pop_back();
			str += "-\n";
		}
		else {
			std::cout << "NO" << '\n';
			return 0;
		}
		
		
	}

	std::cout << str;
	
}