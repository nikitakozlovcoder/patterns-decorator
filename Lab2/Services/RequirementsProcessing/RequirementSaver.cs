using Lab2.Entities;
using Lab2.Services.Store;

namespace Lab2.Services.RequirementsProcessing;

public class RequirementSaver : BaseDecorator<IRequirementProcessor>, IRequirementProcessor
{
    public RequirementSaver(IRequirementProcessor actor) : base(actor)
    {
    }

    public Requirement Process(Requirement requirement)
    {
        requirement = Actor.Process(requirement);
        var store = InMemoryStore<Requirement>.GetStore();
        store.Add(requirement);
        return requirement;
    }
}