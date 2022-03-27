using Lab2.Entities;

namespace Lab2.Services.RequirementsProcessing;

public interface IRequirementProcessor
{
    public Requirement Process(Requirement requirement);
}