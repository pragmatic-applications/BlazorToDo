using System.Collections.Generic;

namespace Interfaces
{
    public interface ITaskService<T>
    {
        void Clear();

        List<T> ToDoItems { get; }

        void AddItem(T toDoItem);

        bool CanRemove { get; }
        void RemoveDone();

        bool CanUndo { get; }
        void Undo();

        bool CanRedo { get; }
        void Redo();
    }
}
