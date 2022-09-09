

public class Account
{
    public string Id { get; set; }
   
    public Account (string id) { Id = id; }
    public override string ToString()
    {
        return $"ID: {Id}";
    }

}

