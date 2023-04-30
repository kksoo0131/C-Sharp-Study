#define MAX_WORKERTHREAD 4 //쓰레드 풀에 넣을 쓰레드 수

HADNLE _IOCPHandle = INVAILD_HANDLE_VALUE;

bool CreateIOCPHandle()
{
  _IOCPHandle = CreateIoCompletionPort(INVAILD_HANDLE_VALUE, NULL, NULL, MAX_WORKERTHREAD);
  if(NULL == _IOCPHandle)
  {
    printf("_IOCPHandle가 NULL이라면 생성 실패 %d\n", GetLastError());
    return false;
  }  
}
