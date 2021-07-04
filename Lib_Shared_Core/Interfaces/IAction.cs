namespace Interfaces
{
    public interface IAction<T>
    {
        T AddItem(T input);
        T Undo(T input);
    }
}
