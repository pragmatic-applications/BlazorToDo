using Domain;

using Interfaces;

using Microsoft.AspNetCore.Components;

namespace To_Do.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject] public ITaskService<ToDoItem> ToDoItemService { get; set; }
        [Inject] public ToDoItem ToDoItem { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            this.ToDoItem = new();
        }

        private void AddItem()
        {
            this.ToDoItemService.AddItem(this.ToDoItem);
            this.ToDoItem = new();
        }
    }
}
