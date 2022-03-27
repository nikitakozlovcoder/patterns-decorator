namespace Lab2.Services.Store;

public class InMemoryStore<T> : IStore<T>
{
    private static InMemoryStore<T>? _store;
    private static readonly List<T> Storage = new();
    private InMemoryStore() { }

    public static InMemoryStore<T> GetStore()
    {
        return _store ??= new InMemoryStore<T>();
    }
    
    public List<T> GetAll()
    {
        return Storage;
    }

    public void Add(T item)
    {
       Storage.Add(item);
    }
}