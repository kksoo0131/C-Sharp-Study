<h2>Delegate</h2>  

<h4>함수 자체를 인자로 넘겨주고 그 함수를 콜백 방식으로 호출하는 문법</h4>


<h5>Ex 1) delegate</h5>
	
```cs
    //delegate -> 함수 자체를 인자로 넘겨주는 형식(type)
    //return = int, 인자 = void인 delegate 형식
    delegate int OnClicked();

    static void ButtonPressed(Onclicked clicked)
    {
      Console.WriteLine("1");
      clicked();
    }

    static int TestDelegate()
    {
      Console.WriteLine("2");
      return 0;
    }
    
    static void Main(string[] args)
    {
      Console.WriteLine("0");
      ButtonPressed(TestDelegate);
    }
```
  
  


<h5>Ex 2) delegate chain: 하나의 델레게이트에 여러개의 함수를 동시에 넘겨줄수있음</h5>
	
```cs

    //delegate -> 함수 자체를 인자로 넘겨주는 형식(type)
    //return = int, 인자 = void인 delegate 형식
    delegate int OnClicked();

    static void ButtonPressed(Onclicked clicked)
    {
      Console.WriteLine("1");
      clicked();
    }

    static int TestDelegate()
    {
      Console.WriteLine("2");
      return 0;
    }
    
    static int TestDelegate2()
    {
      Console.WriteLine("3");
      return 0;
    }
    
    static void Main(string[] args)
    {
      Console.WriteLine("0");
      Onclicked clicked = new Onclicked(TestDelegate);
      clicked() += TestDelegate2;
      // TestDelegate 함수를 실행한 이후에 TestDelegate2 함수가 실행된다.
      
      ButtonPressed(clicked);
    }
```
