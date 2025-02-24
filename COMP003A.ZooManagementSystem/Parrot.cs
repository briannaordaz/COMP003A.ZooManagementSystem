namespace COMP003A.ZooManagementSystem;

 class Parrot : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The parrot squawks!" + " " + Name + " " + Species);
    }
}