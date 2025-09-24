using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List.Shared.Model
{
    internal class ToDoItems
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
