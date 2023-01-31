<h2>Degin Pattern</h2>  


<h4>Command Pattern</h4>

    메소드를 호출할때 커맨드를 거쳐서 호출하는 방법  
    Customer는 Food를 알고있다면
    
```cs
    // Command
    public interface Food { public abstract void cook(); }

    // 기능들을 Command 인터페이스를 이용해 클래스로 만듬
    public class Gambas : Food
    {
        public void cook() { Console.WriteLine("Gambas"); }
    }
    public class Pasta : Food
    {
        public void cook() { Console.WriteLine("Pasta"); }
    }

    public class Customer
    {
        
        private Food food;

        public void Order(Food food) { this.food = food; }

        public void OrderCompleted() 
        { 
            food.cook();
        }
    }
    
    class Program
    {
        public static void Main(string []args)
        {
            Food gambas = new Gambas();
            Food pasta = new Pasta();

            Customer first_customer = new Customer();
            Customer second_customer = new Customer();
            
            first_customer.Order(pasta);
            second_customer.Order(pasta);
            first_customer.Order(gambas);
            
            first_customer.OrderCompleted();
            second_customer.OrderCompleted();
        }
```
    
     
   
    
    
    
  

    
