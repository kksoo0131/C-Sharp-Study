#include <iostream>
#include <deque>
using namespace std;


deque<char> arr[26];
deque<char> arr2[26];
deque<char> arr3[26];

void preorderTraversal(char c) {
	cout << c;
	int idx = c - 65;

	while (!arr[idx].empty()) {
		char next = arr[idx].front();
		arr[idx].pop_front();
		if (next != '.') {
			preorderTraversal(next);
		}	
	}
}

void inorderTraversal(char c) {
	int idx = c - 65;

	char pre = arr2[idx].front();
	char post = arr2[idx].back();
	if (pre != '.') { inorderTraversal(pre);}
	cout << c;
	if (post != '.') { inorderTraversal(post);}

}

void postorderTraversal(char c) {
	int idx = c - 65;

	while (!arr3[idx].empty()) {
		char next = arr3[idx].front();
		arr3[idx].pop_front();
		if (next != '.') {
			postorderTraversal(next);
		}
	}
	cout << c;
}

int main() {
	int N;
	cin >> N;

	for (int i = 0; i < N; i++) {
		
		char temp;
		cin >> temp;
		int idx = temp - 65;

		for (int j = 0; j < 2; j++) {
			cin >> temp;
			arr[idx].push_back(temp);
			arr2[idx].push_back(temp);
			arr3[idx].push_back(temp);
		}
	}

	preorderTraversal('A');
	cout << '\n';
	inorderTraversal('A');
	cout << '\n';
	postorderTraversal('A');
}