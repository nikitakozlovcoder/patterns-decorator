using Lab2.Models;

namespace Lab2.Services.RequirementsProcessing;

public class TimeAdderDecorator : BaseDecorator<IRequirementProcessor>, IRequirementProcessor
{
    public TimeAdderDecorator(IRequirementProcessor actor) : base(actor)
    {
    }
    public void Process(Requirement requirement)
    {
       Actor.Process(requirement);
       requirement.CreatedAtUtc = DateTime.UtcNow;
    }
}