public class B:A{

    // Sealed keyword'ü, bir metodun override edilemez hale sokar!!1
    // metot kalıtım ile geçer ancak davranışı değiştirilemez!!!

    // Sealed olarak işaretlendiği için, B sınıfından türeyen C sınıfında override edilemez!!

    // Ancak C sınıfının nesnesi üzerinden erişilir!!!
    public sealed override  void Metot1()
    {
        base.Metot1();
    }

    // metot2 sealed olmadığı için, B'den kalıtım alan C sınıfında override edilebilir!!
    // C sınıfın nesnesi üzerinden erişilir.!!
    
}