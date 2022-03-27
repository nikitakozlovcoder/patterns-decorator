using Lab2.Entities;

namespace Lab2.Services.RequirementsProcessing;

public class RequirementProcessor : IRequirementProcessor
{
    public Requirement Process(Requirement requirement)
    {
       Console.WriteLine("Your requirement was registered in our system");
       return requirement;
    }
}