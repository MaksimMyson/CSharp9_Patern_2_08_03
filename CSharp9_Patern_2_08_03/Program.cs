namespace CSharp9_Patern_2_08_03
{
    abstract class Implementor
    {
        public abstract void OperationImp();
    }

    
    class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorA operation");
        }
    }

    
    class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorB operation");
        }
    }

   
    class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }

    
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.OperationImp();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Implementor implementorA = new ConcreteImplementorA();
            Implementor implementorB = new ConcreteImplementorB();

            
            Abstraction abstraction1 = new Abstraction();
            abstraction1.Implementor = implementorA;

            Abstraction abstraction2 = new RefinedAbstraction();
            abstraction2.Implementor = implementorB;

           
            abstraction1.Operation();
            abstraction2.Operation();
        }
    }
}
