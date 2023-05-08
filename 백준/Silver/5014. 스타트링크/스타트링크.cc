#include <iostream>
#include <deque>
using namespace std;
int check[1000001] = {0};
int main() {
	int F, S, G, U, D; // 최고층, 시작층, 목표층, 위로이동, 아래로이동
	cin >> F >> S >> G >> U >> D;
	deque<int> position;
		
	position.push_back(S);
	check[S] = 1; // 위로 이동하는게 0일떄 계속같은층에서 머무르는 일을 방지

	while (!position.empty()) {

		int now = position.front();
		position.pop_front();

		if (now == G) {
			cout << check[G]-1;// 1로시작했으니 1을뺴준다.
			return 0;
		}
			

		if (now+U <= F &&check[now + U] == 0) {
			position.push_back(now + U);
			check[now + U] = check[now]+1;
		}

		if (now - D > 0 && check[now - D] == 0) {
			position.push_back(now - D);
			check[now - D] = check[now] + 1;
		}
	}
	cout << "use the stairs";
	
}