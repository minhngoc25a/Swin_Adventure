namespace SwinAdventure;

public class IdentifiableObject
{
    private List<string> _identifiers = new List<string>();

    public IdentifiableObject(string[] idents)
    {
        foreach (var id in idents)
        {
            _identifiers.Add(id.ToLower());
        }
    }

    public bool AreYou(string id)
    {
        return _identifiers.Contains(id.ToLower());
    }

    public string FirstId()
    {
        return _identifiers[0];
    }

    public void AddIdentifier(string id)
    {
        _identifiers.Add(id.ToLower());
    }
}