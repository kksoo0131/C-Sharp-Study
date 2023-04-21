# IOCP - Input/Output Completion Port

  Microsoft Windows 운영체제에서 비동기 I/O작업을 처리하기 위한 메커니즘

1. IOCP는 "비동기 I/O작업" 을 처리하기위해 "대기열(queue)를 사용"한다.

2. 대기열에는 I/O 완료를 나타내는 메시지가 포함되어 있으며, 애플리케이션이 I/O 작업을 수행하고 결과를 받을수 있도록 한다.

3. 대기열은 하나 이상의 "스레드 풀이 연결"되고, 각 스레드는 대기열에서 메시지를 가져와 해당 작업을 처리한다.

        멀티스레드 환경에서 비동기 I/O 작업을 처리하기 위한 메커니즘
        OverlappedI/O + ThreadPool + CompletionQueue 
