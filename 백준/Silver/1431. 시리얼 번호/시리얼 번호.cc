#include <iostream>
#include <string>
#include<map>
#include<vector>
#include <algorithm>

using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0), cout.tie(0);

	int N ;
	cin >> N;
	
	map<int, map<int, vector<string>>> list;
	
	for (int i = 0; i < N; i++) {
		string temp;
		int sum = 0;

		cin >> temp;

		for (char c : temp) {
			if (c < 47 || c < 59)
				sum += c - 48;
		}

		list[temp.length()][sum].push_back(temp);
	}

	for (pair<int, map<int, vector<string>>> length : list) {
		for (pair <int, vector<string>> sum : length.second) {
			sort(sum.second.begin(), sum.second.end());
			for (string str : sum.second) {
				cout << str + '\n';

			}
		}

	}

}