//CompletionPort객체와 소켓과 CompletionKey를 연결시키는 역할을 한다.
	bool BindIOCompletionPort(ClientInfo* pClientInfo)
	{
		//socket과 pClientInfo를 CompletionPort객체와 연결시킨다.
		auto hIOCP = CreateIoCompletionPort((HANDLE)pClientInfo->m_socketClient
										, _IOCPHandle
										, (ULONG_PTR)(pClientInfo), 0);
		
		if (NULL == hIOCP || mIOCPHandle != hIOCP)
		{
			printf("[에러] CreateIoCompletionPort()함수 실패: %d\n", GetLastError());
			return false;
		}

		return true;
	}
