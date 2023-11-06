using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ChristmasTree christmasTree = new ChristmasTree();
            ChristmasTreeToysDecorator toysDecorator = new ChristmasTreeToysDecorator();
            ChristmasTreeGarlandDecorator garlandDecorator = new ChristmasTreeGarlandDecorator();

            // Link decorators
            toysDecorator.SetComponent(christmasTree);
            garlandDecorator.SetComponent(toysDecorator);

            garlandDecorator.Operation();

            // Wait for user
            Console.Read();
        }
    }

    // "Component"
    abstract class Component
    {
        public abstract void Operation();
    }

    // "ConcreteComponent"
    class ChristmasTree : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Ялинка");
        }
    }

    // "Decorator"
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    // "ConcreteDecoratorA"
    class ChristmasTreeToysDecorator : Decorator
    {
        private string toys;

        public override void Operation()
        {
            base.Operation();
            toys = "Якісь іграшки";
            Console.WriteLine("Продекорована ялинковими іграшками");
        }
    }

    // "ConcreteDecoratorB" 
    class ChristmasTreeGarlandDecorator : Decorator
    {
        private bool garlandState = false;

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Операція з гірляндами");
            SwitchGarland();
        }
        void SwitchGarland()
        {
            if (garlandState == true)
            {
                garlandState = false;
                Console.WriteLine("Гірлянди відімкнені");
            }

            else 
            {
                garlandState = true;
                Console.WriteLine("Гірлянди увімкнені");
            }
        }
    }
}
