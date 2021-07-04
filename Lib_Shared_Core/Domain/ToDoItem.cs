using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ToDoItem
    {
        [Required]
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
