public struct Todo
{
    public string Title;
    public int Priority;
    public string Description;

    public Todo()
    {   
        Title = "";
        Priority = Int32.MinValue;
        Description = "";
    }

    public Todo(string title, int priority, string description)
    {
        Title = title;
        Priority = priority;
        Description = description;
    }

    public override string ToString() => $"Todo '{Title}' (Priority: {Priority}): {Description}";
}
