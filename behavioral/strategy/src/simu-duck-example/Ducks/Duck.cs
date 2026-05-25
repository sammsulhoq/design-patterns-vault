using System;
using SimUDuck.Console.Behaviors;

namespace SimUDuck.Console.Ducks;

public abstract class Duck
{
    // Use property-based Dependency Injection instead of open fields
    public IFlyBehavior FlyBehavior { get; set; }
    public IQuackBehavior QuackBehavior { get; set; }

    protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
    {
        FlyBehavior = flyBehavior ?? throw new ArgumentNullException(nameof(flyBehavior));
        QuackBehavior = quackBehavior ?? throw new ArgumentNullException(nameof(quackBehavior));
    }

    public abstract void Display();

    // Context delegates the execution directly to the strategy interface
    public void PerformFly() => FlyBehavior.Fly();
    public void PerformQuack() => QuackBehavior.Quack();

    public void Swim() => System.Console.WriteLine("All ducks float, even decoys!");
}