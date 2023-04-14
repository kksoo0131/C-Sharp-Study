string bigNumAdd(string n1, string n2) {
	int sum = 0;
	string result;

	//문자열을 뒤에서 부터 하나씩 빼서
	// result string에 저장하기 때문에 역순으로 저장된다.
	while (n1.empty() == false || n2.empty() == false || sum) {
		// n1, n2가 비어있지 않다면 or sum이 남아있다면(result에 저장하기 위해서)
		if (n1.empty() == false) {
		// 0의 아스키 코드값을 빼서 정수로만듬
			sum += n1.back() - '0';
			n1.pop_back(); 
		}

		if (n2.empty() == false) {
			sum += n2.back() - '0';
			n2.pop_back();
		}

		result.push_back((sum % 10) + '0');
		//나머지를 다시 문자로 만들어서 저장
		sum /= 10;
	}
	// 역순으로 문자열이 완성 됬기 때문에 뒤집는다.
	reverse(result.begin(), result.end());
	return result;
}
