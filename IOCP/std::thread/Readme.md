[스레드 생성](https://github.com/kksoo0131/Study/blob/main/IOCP/std::thread/%EC%8A%A4%EB%A0%88%EB%93%9C%20%EC%83%9D%EC%84%B1.cpp)

[WorkerThread](https://github.com/kksoo0131/Study/blob/main/IOCP/std::thread/WorkerThread.cpp)

[AccepterThread](https://github.com/kksoo0131/Study/blob/main/IOCP/std::thread/AccpterThread.cpp)


- 라이브러리

[accept()]([accept()](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/accept().cpp))

[GetQueuedCompletionStatus()](https://github.com/kksoo0131/Study/blob/main/IOCP/Windows/GetQueuedCompletionStatus().cpp)


- 사용자 정의

[BindSocket()](https://github.com/kksoo0131/Study/blob/main/IOCP/Windows/IOCP%20%ED%95%B8%EB%93%A4%20%EB%B0%94%EC%9D%B8%EB%93%9C.cpp)

[GetEmptyClientInfo()](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EB%B9%84%EC%96%B4%EC%9E%88%EB%8A%94%20%ED%81%B4%EB%9D%BC%EC%9D%B4%EC%96%B8%ED%8A%B8%20%EC%86%8C%EC%BC%93%20%EB%B0%98%ED%99%98.cpp)

[BindRecv()]()



// joinable() 스레드 객체의 상태를 확인하는 함수, join()함수를 호출 할 수 있는지 여부를 반환 할수없다면 true

// join() 호출된 스레드가 종료될 때까지 대기하는 함수, 레드가 종료될 때까지 현재 스레드가 대기하다 반환된다.
// 스레드가 종료되기 전까지 다른곳에서 사용할 수 없게한다.
