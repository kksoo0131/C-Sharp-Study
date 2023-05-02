int WSASend(                                              // 비동기 IO send
  SOCKET                             s,                   // 소켓 핸들(소켓의 유일한 식별자)
  LPWSABUF                           lpBuffers,           // 버퍼 배열
  DWORD                              dwBufferCount,       // 버퍼 배열의 원소 개수
  LPDWORD                            lpNumberOfBytesSent, // 실제로 전송할 데이터의 크기
  DWORD                              dwFlags,             // 옵션을 지정
  LPWSAOVERLAPPED                    lpOverlapped,        // 비동기I/O를 위한 OVERLAPPED구조체 작업 정보를 저장
  LPWSAOVERLAPPED_COMPLETION_ROUTINE lpCompletionRoutine  // 비동기I/O작업 완료 후 호출될 콜백 함수 (NULL인경우 블로킹)
);

bool SendMsg(ClientInfo* pClientInfo, char* pMsg, int nLen)
{
  
  DWORD dwRecvNumBytes = 0;
  
  // 전송될 메세지를 복사
  CopyMemory(pClientInfo->_sendOverlappedEx._szBuf, pMsg, nLen);
  
  pClientInfo->_sendOverlappedEx._wsaBuf.len = nLen;
  pClientInfo->_sendOverlappedEx._wsaBuf.buf = pClientInfo->_sendOverlappedEx._szBuf;
  pClientInfo->_sendOverlappedEx._eOperation = IOOperation::SEND;
  
  int nRet = WSASend(pClientInfo->_socketClient,
                    &(pClientInfo->_sendOverlappedEx._wsaBuf),
                    1,
                    &dwRecvNumBytes,
                    0,
                    (LPWSAOVERLAPPED)& (pClientInfo->_sendOverlappedEx),
                    NULL);
  
  if (SOCKET_ERROR == nRet && (WSAGetLastError() != ERROR_IO_PENDING))
  {
    printf("WSASend실패 : %d\n", WSAGetLastError());
    return false;
  }
  return true;
  
  
}
