#include <iostream>
#include <map>
#include <string>
#include<deque>

using namespace std;

map<int, deque<string>> dic;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N;
	cin >> N;

	while (N--) {
		int age;
		string name;

		cin >> age >> name;

		dic[age].push_back(name);
	}

	for (pair<int, deque<string>> list : dic) {
		
		for (string name : list.second) {
			cout << list.first << " " << name << '\n';
		}
		
		
	}
}