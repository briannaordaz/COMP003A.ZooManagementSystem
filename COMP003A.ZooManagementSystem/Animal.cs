namespace COMP003A.ZooManagementSystem;

public abstract class Animal
{
    private string _name;
    private string _species;

    public string Name // public property named "Name"
    {
        get { return _name; }
        
        set { if(String.IsNullOrWhiteSpace(value)) 
                 throw new ArgumentException("Name cannot be empty."); 
            _name = value;
        }
        
    }

    public string Species //public property named "Species"
    {
        get { return _species; }
        
        set { if(String.IsNullOrWhiteSpace(value))
                 throw new ArgumentException("Species cannot be empty.");
                _species = value;
        }
    }

    public abstract void MakeSound();


}