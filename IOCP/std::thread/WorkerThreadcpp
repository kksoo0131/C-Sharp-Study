void WorkerThread()
{
  BOOL bSuccess = TRUE;               // 함수 호출 성공 여부
  DWORD dwIoSize = 0;                 // 전송된 데이터 크기
  ClientInfo* pClientInfo = nullptr;  // CompletionKey를 받는다
  OVERLAPPED* lpOverlapped = nullptr; // 작업의 결과가 저장된 OVERLAPPED 구조채 포인터
  
  while (_isWorkerRun)
  {
     	  ///////////////////////////////////////////////////////
	  //이 함수로 인해 쓰레드들은 WaitingThread Queue에      //
	  //대기 상태로 들어가게 된다.                           //
          //                                                   //
	  //완료된 Overlapped I/O작업이 발생하면 IOCP Queue에서  //
	  //완료된 작업을 가져와 뒤 처리를 한다.                  //
	  //                                                   //
	  //그리고 PostQueuedCompletionStatus()함수에의해 사용자 //
	  //메세지가 도착되면 쓰레드를 종료한다.                  //
	  ///////////////////////////////////////////////////////
    
  //GetQueueCompletionStatus()는 IOCP핸들에서 완료된 작업을찾아서
  // 그결과를 dwIoSize, &pClientInfo, &lpOverlapped 에 저장한다
  // 대기시간이 INFINITE이기 떄문에 블록킹 방식으로 완료된 작업이 생길때까지 대기하게된다.
    bSucess = GetQueueCompletionStatus(_IOCPHandle,
                                       &dwIoSize,
                                       (PULONG_PTR)&pClientInfo,
                                       &lpOverlapped,
                                       INFINITE);

	  
    if (FALSE == bSuccess){
      if(NULL == lpOverlapped){
        printf("작업이 아직 완료되지 않음");
        continue;	
      }

      printf("오류 발생 클라이언트 연결 해제");
      CloseSocket(pClientInfo);
      continue;

    }

    if (0 == dwIoSize) 
    {
      if (NULL == lpOverlapped)
      {
        printf("0바이트 패킷이 아닌데 데이터가 없음 스레드를 중지");
        mIsWorkerRun = false; 
        continue;	
      }


        printf("0 바이트 패킷 == 접속종료로 간주");
        CloseSocket(pClientInfo);
        continue;		
    }
    
    // lpOverlapped의 저장된 작업의 결과를 (OverlappedEx*)로 캐스팅.
    OverlappedEx* pOverlappedEx = (OverlappedEx*)lpOvelapped;
    
    // Recv작업의 결과라면
    if (IOOperation :: RECV == pOverlappedEx->_eOperation)
    {
        pOverlappedEx-> _szBuf[dwIoSize] = NULL; // 버퍼의 마지막에 널문자를 추가. (c문자열 출력을 위함)
        printf("[RECV] bytes : %d , msg : %s\n", dwIoSize, pOverlappedEx->_szBuf); // 수신받은 데이터 출력
      
        // 클라이언트에 메세지르 에코.(그대로 돌려보냄)
        SendMsg(pClientInfo, pOverlappedEx-> _szBuf, dwIoSize);
        BindRecv(pClientInfo);
    }
    // Send 작업의 결과라면
    else if (IOOperation::Send == pOverlappedEx -> _eOperation)
    {
        printf("[SEND] bytes : %d, msg: %s \n", dwIoSize, pOverlappedEx->_szBuf);
    }
    else
    {
      printf("socket(%d)에서 예외상황\n", (int)pClientInfo->_socketClient);
    }
    
    
    

    
  }
}
