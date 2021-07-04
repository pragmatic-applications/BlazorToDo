using System.Collections.Generic;

namespace Interfaces
{
    public interface ITaskService<T>
    {
        bool CanRemove { get; }
        void Clear();

        List<T> ToDoItems { get; }

        void AddItem(T toDoItem);
        void RemoveDone();

        bool CanUndo { get; }
        void Undo();

        bool CanRedo { get; }
        void Redo();
    }
}
