using Lab2.Services;
using Lab2.Services.RequirementsProcessing.Builder;

var builder = new RequirementProcessorBuilder();
var processor = builder.AddFormatter().AddTimeSetter().AddLogger().Build();
var userInteractor = new UserInteractorService();

do
{
    var requirement = userInteractor.GetRequirement();
    processor.Process(requirement);
} while (userInteractor.Ask("Continue?"));
