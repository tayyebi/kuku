namespace Api.Models;

public class Person{
    public long Id { get; set; }
    public string? Name { get; set; }
    public List<Contact>? ContactInfo {get; set;}
}

public class Contact
{
    public long Id { get; set; }
    public long PersonId { get; set; }
    public string? Key { get; set; }
    public string? Value { get; set; }
}