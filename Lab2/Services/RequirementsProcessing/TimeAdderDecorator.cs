using Lab2.Entities;

namespace Lab2.Services.RequirementsProcessing;

public class TimeAdderDecorator : BaseDecorator<IRequirementProcessor>, IRequirementProcessor
{
    public TimeAdderDecorator(IRequirementProcessor actor) : base(actor)
    {
    }
    public Requirement Process(Requirement requirement)
    { 
        return Actor.Process(requirement) with
       {
           CreatedAtUtc = DateTime.UtcNow
       };
    }
}