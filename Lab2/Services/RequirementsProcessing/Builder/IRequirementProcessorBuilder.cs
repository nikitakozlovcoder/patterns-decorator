namespace Lab2.Services.RequirementsProcessing.Builder;

public interface IRequirementProcessorBuilder
{
    public IRequirementProcessorBuilder AddLogger();
    public IRequirementProcessorBuilder AddFormatter();
    public IRequirementProcessorBuilder AddTimeSetter();
    public IRequirementProcessor Build();
}