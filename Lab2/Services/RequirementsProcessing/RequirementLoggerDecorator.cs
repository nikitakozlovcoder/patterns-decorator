using Lab2.Entities;

namespace Lab2.Services.RequirementsProcessing;

public class RequirementLoggerDecorator : BaseDecorator<IRequirementProcessor>, IRequirementProcessor
{
    public RequirementLoggerDecorator(IRequirementProcessor actor) : base(actor)
    {
    }

    public Requirement Process(Requirement requirement)
    {
       requirement = Actor.Process(requirement);
       new UserInteractorService().ShowRequirement(requirement);
       return requirement;
    }
}