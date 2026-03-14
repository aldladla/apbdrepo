namespace apbdrepo;

public class Hero
{
    private string name;
    private int age;
    
    public Hero(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"My name is {name} and I am {age} years old.");
    }
}