namespace COMP003A.ZooManagementSystem;

public class ZooUtility
{
    public void DescribeAnimal(string name)
    {
        Console.WriteLine("Name of animal: " + name);
    }

    public void DescribeAnimal(string name, string species)
    {
        Console.WriteLine("Name of animal: " + name + "Species: " + species);
    }

    public void DescribeAnimal(string name, string species, int age)
    {
        Console.WriteLine("Name of animal: " + name + "Species: " + species + "Age: " + age);
    }
    
}