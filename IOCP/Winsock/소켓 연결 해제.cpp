int closesocket(SOCKET s);
//소켓을 닫는 함수, 해당 소켓이 사용 중이던 리소스가 반환되고, 모든 연결도 끊어진다.
//소켓을 닫지 않아 소켓이 계속해서 포트를 점유하고 있게되면, 다른 소켓이 같은 포트를 사용하지 못하게되고, 메모리 누수가 발생할수 있어
// 명시적으로 닫아주는것이 권장된다, 0을 반홚 한다.

int shutdown(SOCKET s, int how);
// 소켓의 한쪽 연결을 종료하는 함수, 소켓의 입출력에 대한 방향을 지정하여, 소켓과 연결된 상대측과의 통신을 종료
// s : 종료할 소켓을 지정
// how : 종료방법 SD_SEND, SD_RECEIVE, SD_BOTH
// 성공시 0, 실패시 SOCKET_ERROR 반환

int setsockopt(SOCKET s, int level, int optname, const char* optval, int optlen);
// 소켓 옵션을 설정하는데 사용된다.
// s : 소켓을 지정
// level : SOL_SOCKET, 소켓 프로토콜에 따라 달라진다.
// optname : SO_LINGER (TCP소켓을 닫을 때 바로 close되지 않고 일정 시간만큼 지연되어 버퍼에 남은 데이터를 전송하고 소켓을 닫는다), 소켓 프로토콜에 따라 달라진다.
// optval : optname이 SO_LINGER이기 떄문에 시간을 지정해준다 (설정하려는 옵션에 대한 값)
// optlen : optval 버퍼의 크기

struct linger {	  //TCP 소켓의 연결을 끊을때 지연 시간을 설정 할 수 있는 구조체
    int l_onoff;  // 지연 시간 사용 여부 (0: 끄기, !=0: 켜기)
    int l_linger; // 지연 시간 값 (초 단위)
};

void CloseSocket(ClientInfo* pClientInfo, bool bisForce = false)
{
  struct linger Linger = {0,0};
  
  if (true == bIsForce)
  {
    Linger.l_onoff=1;
  }
  
  shutdown(pClientInfo->_socketClient, SD_BOTH);
  
  setsockopt(pClientInfo->_socketClient, SOL_SOCKET, SO_LINGER, (char*)&Linger, sizeof(Linger));
  
  closesocket(pClientInfo->m_socketClient);

  pClientInfo->m_socketClient = INVALID_SOCKET;// 클라이언트 소켓을 비워준다.

}
