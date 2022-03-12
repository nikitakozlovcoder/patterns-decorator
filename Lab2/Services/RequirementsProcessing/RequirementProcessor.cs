using Lab2.Models;

namespace Lab2.Services.RequirementsProcessing;

public class RequirementProcessor : IRequirementProcessor
{
    public void Process(Requirement requirement)
    {
       Console.WriteLine("Your requirement was registered in our system");
    }
}