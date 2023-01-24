<h2>Delegate</h2>  

<h4>함수 자체를 인자로 넘겨주고 그 함수를 콜백 방식으로 호출하는 문법</h4>


<h5>Ex 1) delegate</h5>
	
```cs
//delegate -> 함수 자체를 인자로 넘겨주는 형식(type)
//return = int, 인자 = void인 delegate 형식
delegate int OnClicked();

static void ButtonPressed(OnClicked clicked)
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
static void ButtonPressed(OnClicked onclicked)
{
    Console.WriteLine("1");
    onclicked();
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
    OnClicked clicked = new OnClicked(TestDelegate);
    clicked += TestDelegate2;
    // TestDelegate 함수를 실행한 이후에 TestDelegate2 함수가 실행된다.

    ButtonPressed(clicked);
}
```

	

<h2>Event</h2>  

<h4>event를 생성하고 이벤트를 구독한 객체에게 이벤트 발생을 알려주는 Observer Pattern</h4>


<h5>Ex )</h5>
	
```cs
class InputManager
{
	public delegate void OnInputKey();
	//delegate에 event를 붙혀서 만들어준다.
	public event OnInputKey InputKey;

	public void Update()
	{
		if (Console.KeyAvailable == false)
			return;
		ConsoleKeyInfo info = Console.ReadKey();
		if (info.Key == ConsoleKey.A)
		{
			InputKey();
			// event를 수신 받기로한 객체들에게 알려준다.
		}
	}
}

class Program
{
	static void OnInputTest()
	{
		Console.WriteLine("Input Receive");
	}
	static void Main(string[] args)
	{
		InputManager inputManager = new InputManager();

		// event를 구독하고 어떤 함수를 실행할지 정해준다.
		// 함수의 형식은 event를 만들때 쓰인 delegate형식으로 해야한다.
		inputManager.InputKey += OnInputTest;

		while (true)
		{
			inputManager.Update();
		}
	}
	
}

```
<h2>delegate와 event의 차이점</h2>  

<h4>delegate는 마음대로 직접 호출 할 수 있지만, 
event는 구독해서 알림을 받는 것 이외에 직접 호출은 할 수 없다.</h4>


