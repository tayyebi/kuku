namespace Api.Models;

public class Project {

    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsDone { get; set; }
    public List<Transcript>? Transcripts { get; set; }
}