using Lab2.Entities;

namespace Lab2.Services;

public class UserInteractorService : IUserInteractorService
{
    public void ShowRequirement(Requirement requirement)
    {
        Console.WriteLine("---");
        Console.WriteLine(requirement.Title);
        Console.WriteLine(requirement.Description);
        if (requirement.CreatedAtUtc != default)
        {
            Console.WriteLine(requirement.CreatedAtUtc + " UTC");
        }
        Console.WriteLine();
    }

    public Requirement GetRequirement()
    {
        return new Requirement
        {
            Title = GetString("Enter title"),
            Description = GetString("Enter description")
        };
    }

    public bool Ask(string prompt)
    {
        Console.WriteLine(prompt + "(y/n)");
        return Console.ReadLine()?.ToLower() == "y";
    }

    private static string GetString(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine() ?? "";
    }
    
}