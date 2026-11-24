abstract class Publication
{
    public string Title;

    public Publication(string title)
    {
        Title = title;
    }
    public abstract void Publish();
}
