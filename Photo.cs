public class Photo{
    public string Name;

    public Photo(string name)
    {
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine("Нишон додан " + Name);
    }
}