public class RegularUser : User
{
    public  RegularUser (string name ) : base (name) {}

    public override void Viewactivity()
    {
        System.Console.WriteLine($"{Name} tamowo dora ");
    }
    
}