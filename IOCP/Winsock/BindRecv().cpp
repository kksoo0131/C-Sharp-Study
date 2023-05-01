int WSARecv(                                              // 비동기 IO recv
  SOCKET                             s,                   // 소켓 핸들(소켓의 유일한 식별자)
  LPWSABUF                           lpBuffers,           // 버퍼 배열
  DWORD                              dwBufferCount,       // 버퍼 배열의 원소 개수
  LPDWORD                            lpNumberOfBytesRecvd,// 받을 데이터의 크기
  LPDWORD                            lpFlags,             // 옵션을 지정
  LPWSAOVERLAPPED                    lpOverlapped,        // 비동기I/O를 위한 OVERLAPPED구조체 작업 정보를 저장
  LPWSAOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine  // 비동기I/O작업 완료 후 호출된 콜백 함수 (NULL인경우 블로킹)
);
//DWORD WindowsAPI에서 사용하는 unsigned long 자료형
//LPDWORD 는 LongPointer인데 그냥 Pointer라고 생각하면됨
bool BindRecv(ClientInfo* pClientInfo)
{
  DWORD dwFlag = 0;
  DWORD dwRecvNumByttes = 0;
  
  pClientInfo->_recvOverlappedEx._wsaBuf.len = MAX_SOCKBUF;
  pClientInfo->_recvOverlappedEx._wsaBuf.buf = pClientInfo-> _recvOverlappedEx._szbuf;
  pClientInfo->_recvOverlappedEx._eOperation = IOOperation::RECV;
  
  int nRet = WSARecv(pClientInfo-> _socketClient,
                    &(pClientInfo->_recvOverlappedEx._wsaBuf),
                    1,
                    &dwRecvNumBytes,
                    &dwFlag,
                    (LPWSAOVERLAPPED) & (pClientInfo->_recvOverlappedEx),
                    NULL);
  
  if (nRet == SOCKET_ERROR && (WSAGetLastError() != ERROR_IO_PENDING))
  {
      printf("WSARecv()실패 %d\n", WSAGetLastError());
    return false;
  }
  return true;
}
