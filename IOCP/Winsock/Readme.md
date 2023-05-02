## WinSock2.h

[라이브러리 초기화](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EB%9D%BC%EC%9D%B4%EB%B8%8C%EB%9F%AC%EB%A6%AC%20%EC%B4%88%EA%B8%B0%ED%99%94.cpp)

[주소 설정](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EC%A3%BC%EC%86%8C%20%EC%84%A4%EC%A0%95.cpp)

[소켓 생성](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EC%86%8C%EC%BC%93%20%EC%83%9D%EC%84%B1.cpp)

[BIND](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/BIND.cpp)

[LISTEN](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/LISTESN.cpp)

[클라이언트 소켓 생성](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%ED%81%B4%EB%9D%BC%EC%9D%B4%EC%96%B8%ED%8A%B8%20%EC%86%8C%EC%BC%93%20%EC%83%9D%EC%84%B1.cpp)

[비어있는 클라이언트 소켓 반환](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EB%B9%84%EC%96%B4%EC%9E%88%EB%8A%94%20%ED%81%B4%EB%9D%BC%EC%9D%B4%EC%96%B8%ED%8A%B8%20%EC%86%8C%EC%BC%93%20%EB%B0%98%ED%99%98.cpp)

[accept()](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/accept().cpp)

[BindRecv()](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/BindRecv().cpp)

[SendMsg()](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/SendMsg().cpp)
```cpp

int WSASend(                                              // 비동기 IO send
  SOCKET                             s,                   // 소켓 핸들(소켓의 유일한 식별자)
  LPWSABUF                           lpBuffers,           // 버퍼 배열
  DWORD                              dwBufferCount,       // 버퍼 배열의 원소 개수
  LPDWORD                            lpNumberOfBytesSent, // 실제로 전송할 데이터의 크기
  DWORD                              dwFlags,             // 옵션을 지정
  LPWSAOVERLAPPED                    lpOverlapped,        // 비동기I/O를 위한 OVERLAPPED구조체 작업 정보를 저장
  LPWSAOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine  // 비동기I/O작업 완료 후 호출될 콜백 함수 (NULL인경우 블로킹)
);

//WSAOVERLAPPED는 비동기 소켓 입출력 작업에서 사용되는 구조체, 입출력 작업을 지시하고 작업이 완료될 때 정보를 제공.

//closesocket() 소켓을 닫는 함수, 해당 소켓이 사용 중이던 리소스가 반환되고, 모든 연결도 끊어진다.
//소켓을 닫지 않아 소켓이 계속해서 포트를 점유하고 있게되면, 다른 소켓이 같은 포트를 사용하지 못하게되고, 메모리 누수가 발생할수 있어
// 명시적으로 닫아주는것이 권장된다.

// shutdown() 소켓의 한쪽 연결을 종료하는 함수, 소켓의 입출력에 대한 방향을 지정하여, 소켓과 연결된 상대측과의 통신을 종료
// 첫번쨰 인자 종료할 소켓을 지정
// 두번쨰 인자 방향을 지정 SD_SEND, SD_RECEIVE, SD_BOTH

// setsockopt() 소켓 옵션을 설정하는데 사용된다.
// 첫번째 인자 소켓을 지정
// 두번쨰 인자 설정하려는 옵션의 범위를 지정, 보통 SOL_SOCKET
// 세번쨰 인자 옵션의 이름을 지정, SO_LINGER (TCP소켓을 닫을 때 바로 close되지 않고 일정 시간만큼 지연되어 버퍼에 남은 데이터를 전송하고 소켓을 닫는다)
// 네번쨰 인자는 설정하려는 옵션에 대한 값 (일정 시간을 정해준다.)

struct linger {	  //TCP 소켓의 연결을 끊을때 지연 시간을 설정 할 수 있는 구조체
    int l_onoff;  // 지연 시간 사용 여부 (0: 끄기, !=0: 켜기)
    int l_linger; // 지연 시간 값 (초 단위)
};
 
```
