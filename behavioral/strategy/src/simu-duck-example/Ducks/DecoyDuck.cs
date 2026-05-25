using System;
using SimUDuck.Console.Behaviors;

namespace SimUDuck.Console.Ducks;

public class DecoyDuck : Duck
{
    public DecoyDuck() : base(new FlyNoWay(), new MuteQuack()) { }

    public override void Display() => System.Console.WriteLine("It's just a wooden decoy duck.");
}