<h2>Server</h2>  

<h4>Server 동작</h4>
    
    
    Server Program이 실행되면 서버의 IPEndPoint 정보를 인자로 소켓을 생성하고 
   
    Bind(), Listen()를 통해 소켓을 수신대기 상태로 만들어준다.
    
    그리고, 요청을 받으면 Accept()하고 해당 Client에 대한 Session을 생성한다.
    
    Session에서 RecvBuffer, SendBuffer를 통해서 클라이언트와의 Send, Recv를 처리한다.
    
    
    Client Program또한 실행 시 IPendPoint 정보로 소켓을 생성하고
    
    Connect요청을 한후 완료되면 해당 Server에 대한 Session을 생성하고
    
    Session에서 RecvBuffer, SendBuffer를 통해서 서버와의 Send, Recv를 처리한다.
    
    
    

<h5>1. Listener</h5>

    클라이언트의 요청을 받고 Accept해 서버의 프로그램에 해당 클라이언트의 Session을 생성한다.
    
    
<h5>2. Session</h5>

    서버와 클라이언트가 연결되면 생성되고 Recv, Send등의 데이터를 보내고 받는 과정이 일어난다.

