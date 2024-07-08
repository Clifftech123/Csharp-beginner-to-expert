

namespace lesson9
{

    public abstract class Device
{
    public abstract void TurnOn();
    public abstract void TurnOff();
}

public class Smartphone : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("Smartphone turning on");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Smartphone turning off");
    }
}
}