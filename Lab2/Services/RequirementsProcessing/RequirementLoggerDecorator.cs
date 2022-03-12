using Lab2.Models;

namespace Lab2.Services.RequirementsProcessing;

public class RequirementLoggerDecorator : BaseDecorator<IRequirementProcessor>, IRequirementProcessor
{
    public RequirementLoggerDecorator(IRequirementProcessor actor) : base(actor)
    {
    }

    public void Process(Requirement requirement)
    {
       Actor.Process(requirement);
       new UserInteractorService().ShowRequirement(requirement);
    }
}