using Lab2.Entities;
using Lab2.Services;
using Lab2.Services.RequirementsProcessing.Builder;
using Lab2.Services.Store;

var builder = new RequirementProcessorBuilder();
var processor = builder.AddFormatter().AddTimeSetter().AddLogger().AddStoreSaver().Build();
var userInteractor = new UserInteractorService();
var store = InMemoryStore<Requirement>.GetStore();
do
{
    var requirement = userInteractor.GetRequirement();
    processor.Process(requirement);
    if (userInteractor.Ask("Show saved?"))
    {
        foreach (var item in store.GetAll())
        {
            userInteractor.ShowRequirement(item);
        }
    }
} while (userInteractor.Ask("Continue?"));
