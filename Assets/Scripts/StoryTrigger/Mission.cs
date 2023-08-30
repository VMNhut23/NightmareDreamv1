[System.Serializable]
public class Mission
{
    public string Name;
    public string Description;
    public bool IsCompleted;

    public Mission(string name, string description)
    {
        Name = name;
        Description = description;
        IsCompleted = false;
    }
}


