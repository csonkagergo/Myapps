using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{ 
  abstract class Animal
{
    protected string Name;
    abstract public void Sleep();
    abstract public void Hunt();
    abstract public void Sound();

}

class Cat : Animal
{
    private List<Cat> Kids;
    public Cat(string aName)
    {
        Name = aName;
    }

    internal void Born(int v)
    {
        Kids = new List<Cat>();
        for (int i = 0; i < v; i++)
        {
            Kids.Add(new Cat("cica" + i.ToString()));
        }


    }
    internal void Child()
    {
        foreach (var item in Kids)
        {
            Console.WriteLine(Name + "s child name" + item.Name);

        }
    }
    public Cat()
    {

    }
    public override void Sleep()
    {
        Console.WriteLine(Name + " is sleeping....");
    }
    public override void Hunt()
    {
        Console.WriteLine(Name + " is hunting....");
    }
    public override void Sound()
    {
        Console.WriteLine(Name + " nyávog....");
    }
}
class Dog : Animal
{
    public Dog(string aName)
    {
        Name = aName;

    }
    public override void Sleep()
    {
        Console.WriteLine(Name + " is sleeping....");
    }
    public override void Hunt()
    {
        Console.WriteLine(Name + " is hunting....");
    }
    public override void Sound()
    {
        Console.WriteLine(Name + " ugat....");

    }
}

}

