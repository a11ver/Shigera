using System;

namespace laba_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "Егор"));
            s.Attach(new ConcreteObserver(s, "Маргарита"));
            s.Attach(new ConcreteObserver(s, "Никита"));

            s.SubjectState = "оболтус";
            s.Notify();

            Console.ReadKey();
        }
    }
}
