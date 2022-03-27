namespace Lab2.Services.Store;

public interface IStore<T>
{
    List<T> GetAll();
    void Add(T item);
}