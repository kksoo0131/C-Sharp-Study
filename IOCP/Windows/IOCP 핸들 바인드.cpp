
HANDLE BindIoCompletionPort(          // IOCP 핸들과 핸들(소켓)을 연결
  HANDLE    FileHandle,               // IOCP 핸들
  HANDLE    CompletionKey,            // 소켓 컨텍스트(핸들) 정보와 연결할 완료 키 
  ULONG_PTR CompletionValue,          // 완료 패킷에 대한 컨텍스트 정보
  DWORD     NumberOfConcurrentThreads // 작업처리 쓰레드 수
);

bool BindSocket(ClientInfo* pClientInfo)
{
  auto hIOCP = BindIoCompletionPort(_IOCPHandle, (HANDLE)pClientInfo->_socketClient, (ULONG_PTR)(pClientInfo), 0);
  
  if (NULL= hIOCP || _IOCPHANDLE != hIOCP)
  {
    printf("BindIoCompletionPort() 실패 : %d\n",GetLastError());
    return false;
  }
  return true;
}
