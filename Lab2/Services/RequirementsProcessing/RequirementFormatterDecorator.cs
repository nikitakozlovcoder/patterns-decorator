using Lab2.Entities;

namespace Lab2.Services.RequirementsProcessing;

public class RequirementFormatterDecorator : BaseDecorator<IRequirementProcessor>, IRequirementProcessor
{
    public RequirementFormatterDecorator(IRequirementProcessor actor) : base(actor)
    {
    }
    
    public Requirement Process(Requirement requirement)
    {
        return Actor.Process(requirement) with
        {
            Title = $"Title: {requirement.Title}",
            Description = $"Description: {requirement.Description}"
        };
    }
}