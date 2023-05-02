[이전 페이지](https://github.com/kksoo0131/Study)
# IOCP - Input/Output Completion Port

  Microsoft Windows 운영체제에서 비동기 I/O작업을 처리하기 위한 메커니즘
  

1. OverlappedI/O : 비동기 I/O작업을 수행하는 데 사용되는 Windows API

2. CompletionQueue : 비동기 I/O작업의 결과를 관리하는 대기열, 작업이 완료되면 결과를 큐에 넣어둔다.

3. ThreadPool : 작업 스레드를 미리 만들어놓고 대기열에 있는 작업을 스레드를 할당하여 처리한다.

        수행된 비동기 작업들을 Queue와 ThreadPool을 사용하여 오버헤드 없이 효율적으로 처리한다.
        
        (오버헤드 - 작업을 처리하는 데 들어가는 추가적인 비용이나 시간)

[헤더파일](https://github.com/kksoo0131/Study/blob/main/IOCP/IOCPHeader.h)

[Winsock2](https://github.com/kksoo0131/Study/tree/main/IOCP/Winsock) - [라이브러리 초기화](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EB%9D%BC%EC%9D%B4%EB%B8%8C%EB%9F%AC%EB%A6%AC%20%EC%B4%88%EA%B8%B0%ED%99%94.cpp), [주소 설정](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EC%A3%BC%EC%86%8C%20%EC%84%A4%EC%A0%95.cpp), [소켓 생성](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EC%86%8C%EC%BC%93%20%EC%83%9D%EC%84%B1.cpp), [BIND](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/BIND.cpp), [LISTEN](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/LISTESN.cpp), 
[클라이언트 소켓 생성](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%ED%81%B4%EB%9D%BC%EC%9D%B4%EC%96%B8%ED%8A%B8%20%EC%86%8C%EC%BC%93%20%EC%83%9D%EC%84%B1.cpp), [비어있는 클라이언트 소켓 반환](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EB%B9%84%EC%96%B4%EC%9E%88%EB%8A%94%20%ED%81%B4%EB%9D%BC%EC%9D%B4%EC%96%B8%ED%8A%B8%20%EC%86%8C%EC%BC%93%20%EB%B0%98%ED%99%98.cpp), [accept()](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/accept().cpp), [BindRecv()](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/BindRecv().cpp), [SendMsg()](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/SendMsg().cpp), [소켓 연결 해제](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EC%86%8C%EC%BC%93%20%EC%97%B0%EA%B2%B0%20%ED%95%B4%EC%A0%9C.cpp)


[Windows.h](https://github.com/kksoo0131/Study/blob/main/IOCP/Windows.md) - [IOCP 핸들 생성](https://github.com/kksoo0131/Study/blob/main/IOCP/Windows/IOCP%20%ED%95%B8%EB%93%A4%20%EC%83%9D%EC%84%B1.cpp), [IOCP 핸들 바인드](https://github.com/kksoo0131/Study/blob/main/IOCP/Windows/IOCP%20%ED%95%B8%EB%93%A4%20%EB%B0%94%EC%9D%B8%EB%93%9C.cpp), [GetQueuedCompletionStatus()](https://github.com/kksoo0131/Study/blob/main/IOCP/Windows/GetQueuedCompletionStatus().cpp),
[CloseHandle()](https://github.com/kksoo0131/Study/blob/main/IOCP/Windows/CloseHandle().cpp)


[std::thread](https://github.com/kksoo0131/Study/blob/main/IOCP/std::thread.md) - [CreateThread](https://github.com/kksoo0131/Study/blob/main/IOCP/std::thread/%EC%9B%8C%EC%BB%A4%20%EC%8A%A4%EB%A0%88%EB%93%9C%20%EC%83%9D%EC%84%B1.cpp), [WorkerThread](https://github.com/kksoo0131/Study/blob/main/IOCP/std::thread/WorkerThread.cpp), [AccepterThread](https://github.com/kksoo0131/Study/blob/main/IOCP/std::thread/AccpterThread.cpp), [스레드 파괴](https://github.com/kksoo0131/Study/blob/main/IOCP/std::thread/%EC%8A%A4%EB%A0%88%EB%93%9C%20%ED%8C%8C%EA%B4%B4.cpp)




      
[에러 코드 관련](https://github.com/kksoo0131/Study/blob/main/IOCP/Error.md)
