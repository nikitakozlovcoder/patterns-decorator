namespace Lab2.Services.RequirementsProcessing.Builder;

public class RequirementProcessorBuilder : IRequirementProcessorBuilder
{
    private IRequirementProcessor _processor = new RequirementProcessor();
    public IRequirementProcessorBuilder AddLogger()
    {
        _processor = new RequirementLoggerDecorator(_processor);
        return this;
    }

    public IRequirementProcessorBuilder AddFormatter()
    {
        _processor = new RequirementFormatterDecorator(_processor);
        return this;
    }

    public IRequirementProcessorBuilder AddTimeSetter()
    {
        _processor = new TimeAdderDecorator(_processor);
        return this;
    }

    public IRequirementProcessorBuilder AddStoreSaver()
    {
        _processor = new RequirementSaver(_processor);
        return this;
    }

    public IRequirementProcessor Build()
    {
        var processor = _processor;
        _processor = new RequirementProcessor();
        return processor;
    }
}