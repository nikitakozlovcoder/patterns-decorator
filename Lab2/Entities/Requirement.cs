namespace Lab2.Entities;

public record Requirement
{
    public string Title { get; init; } = "";
    public string Description { get; init; } = "";
    public DateTime CreatedAtUtc { get; init; }
}