 public class ProcessedPhoto : Photo
{
    public string Filter;

    public ProcessedPhoto(string name, string filter) : base(name)
    {
        Filter = filter;
    }

    public override void Display()
    {
        base.Display();   
        Console.WriteLine("Filtr " + Filter);   
    }
}