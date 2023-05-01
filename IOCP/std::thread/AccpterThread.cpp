void AccpeterThread()
{
  SOCKADDR_IN _clientAddr;
  int nAddrLen = sizeof(SOCKADDR_IN);
  
  while(_isAccepterRun)
  {
    // 접속을 받을 비어있는 Client슬롯을 가르킨다.
    ClientInfo* pClientInfo = GetEmptyClientInfo();
    
    if (NULL = pClientInfo)
    {
      printf("클라이언트 소켓이 가득 참");
      return;
    }
    
    // 동기방식으로 클라이언트 접속 요청을 기다림 (추후 수정)
    pClientInfo -> _socketClient = accept(_listenSocket, (SOCKADDR*)&_clientAddr, &nAddrLen);
    
    if(INVALID_SOCKET == pClientInfo->_socketClient)
    {
      printf("소캣을 받지못함 재시도");
      continue;
    }
    
    // IOCP핸들과 클라이언트 소켓을 연결?
    bool bRet = BindSocket(pClientInfo);
    if(false == bRet)
    {
      printf("핸들과 클라이언트 연결 실패");
      return;
    }
    
    bRet = BindRecv(pClientInfo);
    if(false == bRet)
    {
      printf("BindRecv 실패");
      return;
    }
    
    // accept한 클라이언트의 주소를 inet_ntop으로 호스트 바이트 순서로 바꾸어서 출력한다.
    char clientIP[32] = {0, };
    inet_ntop(AF_INET, &(_clientAddr.sin_addr), clientIP, 32-1);
    printf("클라이언트 접속 : IP (%s) SOCKET(%d)\n", clientIP, (int)pClientInfo-> _socketClient);
    
    ++_clientCnt;
  }
  
}
