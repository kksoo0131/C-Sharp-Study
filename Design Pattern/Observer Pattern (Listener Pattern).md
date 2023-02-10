<h2>Observer Pattern (Listener Pattern)</h2>
    
    Subject에서는 Observer List를 가지고 있고
    Subject의 메소드를 통해서 Observer들에게 정보를 전달한다.
    C#에서의 Delegate가 Observer Pattern의 예시이다.

```cs
using System;
using System.Collections.Generic;

public interface ISubject
{
    public void AddObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void Notify();
}
public interface IObserver
{
  public void Update();
}


public class Subject : ISubject
{
    List<IObserver> o_l = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        o_l.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        o_l.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver o in o_l)
        {
            o.Update();
        }
    }
}

public class OA : IObserver
{
    public OA(Subject s)
    {
        s.AddObserver(this);
    }
    public void Update()
    {
        Console.WriteLine("A");
    }
}

public class OB : IObserver
{
    public OB(Subject s)
    {
        s.AddObserver(this);
    }
    public void Update()
    {
        Console.WriteLine("B");
    }
}

class Program
    {
        static void Main(string[] args)
        {
            Subject Click_A = new Subject();
            Subject Click_B = new Subject();
            OA obj1 = new OA(Click_A);
            OB obj2 = new OB(Click_A);
            OB obj3 = new OB(Click_B);
            OB obj4 = new OB(Click_B);
            OB obj5 = new OB(Click_B);
            OA obj6 = new OA(Click_B);

            Click_A.Notify();
            Console.WriteLine("");
            Click_B.Notify();
        }
    }


```

