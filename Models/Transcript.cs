namespace Api.Models;

public class Transcript
{
    public long Id { get; set; }
    public DateOnly Happening { get; set; }
    public ICollection<Person>? Attendies { get; set; }
    public string? Session { get; set; }
    public string? Decisions { get; set; }
    public ICollection<Trade>? Trades { get; set; }

}