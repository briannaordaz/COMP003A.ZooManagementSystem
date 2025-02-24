namespace COMP003A.ZooManagementSystem;

// Author: Brianna Ordaz
// Course: COMP-003A
// Faculty:Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
class Program
{
    static void Main(string[] args)
    {
        
        List<Animal> AnimalsList = new List<Animal>(); 

        
       
        string choice;

        while (true)
        {

          
            
            Console.WriteLine("Welcome to the Zoo Management System!");
            
            Console.WriteLine("1. Add a Lion");
            
            Console.WriteLine("2. Add a Parrot");
            
            Console.WriteLine("3. Display All Animals");
            
            Console.WriteLine("4. Describe an Animal");
            
            Console.WriteLine("5. Exit");
            
            Console.WriteLine("Please choose an option: "); 
            choice = Console.ReadLine();
            
            
            if (choice == "1")
            {
                Console.WriteLine("Enter the name of the lion: ");
                string lionName = Console.ReadLine();

                if (lionName.Any(char.IsDigit))
                {
                    Console.WriteLine("Only characters are allowed, no numbers.");
                    return;
                }
                
                
                Console.WriteLine("Enter the species of the lion: ");
                 string lionSpecies = Console.ReadLine();
                 if (lionSpecies.Any(char.IsDigit))
                 {
                     Console.WriteLine("Only characters are allowed, no numbers.");
                     return;
                 }
                AnimalsList.Add(new Lion { Name = lionName,  Species = lionSpecies });
               
                
                
                Console.WriteLine("Lion added succesfully!");
                
                
            }

            else if (choice == "2")
            {
                Console.WriteLine("Enter the name of the parrot: ");
                string parrotName = Console.ReadLine();
                if (parrotName.Any(char.IsDigit))
                {
                    Console.WriteLine("Only characters are allowed, no numbers.");
                    return;
                }

                Console.WriteLine("Enter the species of the parrot: ");
                string parrotSpecies = Console.ReadLine();
                if (parrotSpecies.Any(char.IsDigit))
                {
                    Console.WriteLine("Only characters are allowed, no numbers.");
                    return;
                }
                
                AnimalsList.Add(new Parrot { Name = parrotName, Species = parrotSpecies });
                
                Console.WriteLine("Parrot added succesfully!");
                
            }
            else if (choice == "3")
            {
                Console.WriteLine("Displaying all Animals:");

                if (AnimalsList.Count > 0)
                {
                    foreach (Animal animal in AnimalsList)
                    {
                        animal.MakeSound();
                    }
                }
                else
                {
                    Console.WriteLine("There are no animals in the list.");
                }
            }
            
            else if (choice == "4") //if the number 4 gets chosen
            {
                Console.WriteLine("Describing animals:"); //it will output: "Describing animals:"
                Console.WriteLine("What is the name of the animal?"); // This will ask the name of the animal
                string animalNames = Console.ReadLine(); //this is where the input of the user will be stored
                
                Animal nameOfAnimal = AnimalsList.Find(x => x.Name == animalNames); //this will try to find the animal in the list
                if (nameOfAnimal != null) //if the variable "nameOfAnimal" is not empty
                {
                    ZooUtility zoo = new ZooUtility();
                    Console.WriteLine("CHoose one of the options below");
                    Console.WriteLine("Name (1)");
                    Console.WriteLine("Name, Species (2)");
                    Console.WriteLine("Name, Species, Age (3)");
                    
                    string choice2 = Console.ReadLine();

                    if (choice2 == "1")
                    {
                        zoo.DescribeAnimal(nameOfAnimal.Name);
                        
                    }
                    else if (choice2 == "2")
                    {
                        zoo.DescribeAnimal($"{nameOfAnimal.Name} \n {nameOfAnimal.Species}");
                    }
                    else if (choice2 == "3")
                    {
                        Console.WriteLine("Age of animal: ");
                        int ageOfAnimal;
                        
                        if (int.TryParse(Console.ReadLine(), out ageOfAnimal))
                        {
                            if (ageOfAnimal >= 0)
                            {
                                zoo.DescribeAnimal($"{nameOfAnimal.Name}, \n {nameOfAnimal.Species}, \n {ageOfAnimal}");
                            }
                            
                            else
                            {
                                Console.WriteLine("Age of animals cannot be negative.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Only enter a valid number!!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please choose a number 1 to 3: ");
                    }
                    
                }
            }

            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            
            else { Console.WriteLine("Invalid number, please pick a number from 1 to 5!");}
        }
        
       
        
            
            
        
    }
}