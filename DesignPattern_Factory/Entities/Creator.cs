using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory.Entities
{
    abstract class Creator
    {

        public abstract IProduct FactoryMethod();
        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with "
                         + product.Operation();

            return result;
        }
        public interface IProduct
        {
            string Operation();
        }
        public class ConcreteProduct1 : IProduct
        {
            public string Operation()
            {
                return "{Result of ConcreteProduct1}";
            }
        }



        public class ConcreteCreator1 : Creator
        {
            // Note that the signature of the method still uses the abstract product
            // type, even though the concrete product is actually returned from the
            // method. This way the Creator can stay independent of concrete product
            // classes.
            public override IProduct FactoryMethod()
            {
                return new ConcreteProduct1();
            }
        }


        public class ConcreteCreator2 : Creator
        {
            public override IProduct FactoryMethod()
            {
                return new ConcreteProduct2();
            }
        }
        public class ConcreteProduct2 : IProduct
        {
            public string Operation()
            {
                return "{Result of ConcreteProduct2}";
            }
        }


        public class Client
        {
            public void Main()
            {
                Console.WriteLine("App: Launched with the ConcreteCreator1.");
                ClientCode(new ConcreteCreator1());

                Console.WriteLine("");

                Console.WriteLine("App: Launched with the ConcreteCreator2.");
                ClientCode(new ConcreteCreator2());
            }

            // The client code works with an instance of a concrete creator, albeit
            // through its base interface. As long as the client keeps working with
            // the creator via the base interface, you can pass it any creator's
            // subclass.
            public void ClientCode(Creator creator)
            {
                // ...
                Console.WriteLine("Client: I'm not aware of the creator's class," +
                                  "but it still works.\n" + creator.SomeOperation());
                // ...
            }
        }
    }
}
