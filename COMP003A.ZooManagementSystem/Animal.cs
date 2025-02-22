namespace COMP003A.ZooManagementSystem;

public abstract class Animal
{
    private string _name;
    private string _species;

    public string Name
    {
        get { return _name; }
        
        set { if(String.IsNullOrWhiteSpace(value)) 
                { throw new ArgumentException("Name cannot be null or whitespace."); } 
            _name = value;
        }
        
    }

    public string Species
    {
        get { return _species; }
        
        set { if(String.IsNullOrWhiteSpace(value))
                { throw new ArgumentException("Species cannot be empty.");} 
                _species = value;
        }
    }

    public abstract void MakeSound();


}