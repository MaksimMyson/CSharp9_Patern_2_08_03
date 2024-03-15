namespace CSharp9_Patern_2_08_03
{
    interface ITarget
    {
        void Request();
    }

    
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee's specific request");
        }
    }

    
    class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Adaptee adaptee = new Adaptee();

            // Створення адаптера
            ITarget adapter = new Adapter(adaptee);

            
            adapter.Request();
        }
    }
}
