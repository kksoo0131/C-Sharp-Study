<h2>Synchronous & Asynchronous </h2>  

<h4>어떤 "흐름"으로 처리 할 것인가에 대한 관점</h4>


Synchronous 동기
	
	함수 A가 함수 B의 리턴을 받는다.


Asynchronous 비동기

	함수 A는 함수 B의 작업 완료 여부를 신경 쓰지 않는다
	함수 B를 호출 할때 콜백 함수를 전달해서 함수 B의 작업이 완료되면 콜백 함수를 실행 
  


<h2>Blocking & Non-Blocking</h2>  

<h4>제어권이 어디로 가는지에 대한 관점</h4>


Blocking

	함수 A가 함수 B에게 제어권을 넘겨준다.
	제어권을 넘겨주었기때문에 함수 A는 함수 B가 완료 될때까지 대기한다.

Non-Blocking
		
		함수 A가 함수 B를 호출해도 제어권은 함수 A가 그대로 가지고있는다.
		함수 A와 함수 B가 둘다 실행된다


[참고 자료]
[https://inpa.tistory.com](https://inpa.tistory.com/entry/%F0%9F%91%A9%E2%80%8D%F0%9F%92%BB-%EB%8F%99%EA%B8%B0%EB%B9%84%EB%8F%99%EA%B8%B0-%EB%B8%94%EB%A1%9C%ED%82%B9%EB%85%BC%EB%B8%94%EB%A1%9C%ED%82%B9-%EA%B0%9C%EB%85%90-%EC%A0%95%EB%A6%AC#thankYou)
