# IOCP - Input/Output Completion Port

  Microsoft Windows 운영체제에서 비동기 I/O작업을 처리하기 위한 메커니즘
  

1. OverlappedI/O : 비동기 I/O작업을 수행하는 데 사용되는 Windows API

2. CompletionQueue : 비동기 I/O작업의 결과를 관리하는 대기열, 작업이 완료되면 결과를 큐에 넣어둔다.

3. ThreadPool : 작업 스레드를 미리 만들어놓고 대기열에 있는 작업을 스레드를 할당하여 처리한다.

        수행된 비동기 작업들을 Queue와 ThreadPool을 사용하여 오버헤드 없이 효율적으로 처리한다.
        
        (오버헤드 - 작업을 처리하는 데 들어가는 추가적인 비용이나 시간)
