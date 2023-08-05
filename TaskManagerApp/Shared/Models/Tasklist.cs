using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp.Shared.Models
{
    public class TaskList
    {
        public List<TaskItem> Tasklist { get; set; } = new List<TaskItem>();
    }
}
