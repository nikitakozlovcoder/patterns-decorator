namespace Lab2.Services.RequirementsProcessing;

public abstract class BaseDecorator<T>
{
    protected readonly T Actor;

    protected BaseDecorator(T actor)
    {
        Actor = actor;
    }
}