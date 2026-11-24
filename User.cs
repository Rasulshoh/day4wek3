public class User
{
    public string Name {get ; set;}


    public User (string name)
    {
        Name=name;

    }
     
     public virtual void Viewactivity()
    {
        System.Console.WriteLine("Aktivnost " + Name);
    }
}