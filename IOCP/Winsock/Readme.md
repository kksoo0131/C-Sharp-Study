```cpp
#pragma comment(lib, "ws2_32")
#include <winsock2.h>
#include <Ws2tcpip.h>

class IOCP{
  WSADATA _wsadata;
  SOCKET _listenSocket = INVALID_SOCKET;
  SOCKADDR_IN _serverAddr;
};

```


[라이브러리 초기화](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EB%9D%BC%EC%9D%B4%EB%B8%8C%EB%9F%AC%EB%A6%AC%20%EC%B4%88%EA%B8%B0%ED%99%94.cpp)

[소켓 생성](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/%EC%86%8C%EC%BC%93%20%EC%83%9D%EC%84%B1.cpp)

[BIND](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/BIND.cpp)

[LISTEN](https://github.com/kksoo0131/Study/blob/main/IOCP/Winsock/LISTESN.cpp)
