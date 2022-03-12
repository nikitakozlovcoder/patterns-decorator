using Lab2.Models;

namespace Lab2.Services;

public interface IUserInteractorService
{
    public void ShowRequirement(Requirement requirement);
    public Requirement GetRequirement();
    bool Ask(string prompt);
}