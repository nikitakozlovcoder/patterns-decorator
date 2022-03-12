using Lab2.Models;

namespace Lab2.Services.RequirementsProcessing;

public interface IRequirementProcessor
{
    public void Process(Requirement requirement);
}