#include <vector>

enum class IOOperation{
  RECV,
  SEND
};
struct OverlappedEx{
  WSAOVERLAPPED _wsaOverlapped;
  SOCKET _socketClient;
  WSABUF _wsaBuf;
  char _szBuf[MAX_SOCKBUF];
  IOOperation _eOperation;
};
//WSAOVERLAPPED는 비동기 소켓 입출력 작업에서 사용되는 구조체, 입출력 작업을 지시하고 작업이 완료될 때 정보를 제공.

struct ClientInfo{
  SOCKET _socketClient;
  OverlappedEx _recvOverlappedEx;
  OverlappedEx _sendOverlappedEx;
  
  ClientInfo(){
    ZeroMemory(&_recvOverlappedEx, sizeof(OverlappedEx));
    ZeroMemory(&_sendOverlappedEx, sizeof(OverlappedEx));
    _socketClient = INVALIED_SOCKET;
  }
};

std::vector<ClientInfo> _ClientInfos;

void CreateClient(const UINT32 maxClientCount)
{
  for (UINT32 i = 0; i < maxClientCount; ++i)
  {
    mClientInfos.emplace_back();
  }
}
