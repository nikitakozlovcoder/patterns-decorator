using Lab2.Models;

namespace Lab2.Services.RequirementsProcessing;

public class RequirementFormatterDecorator : BaseDecorator<IRequirementProcessor>, IRequirementProcessor
{
    public RequirementFormatterDecorator(IRequirementProcessor actor) : base(actor)
    {
    }
    public void Process(Requirement requirement)
    {
        Actor.Process(requirement);
        requirement.Title = $"Title: {requirement.Title}";
        requirement.Description = $"Description: {requirement.Description}";
    }
    
}