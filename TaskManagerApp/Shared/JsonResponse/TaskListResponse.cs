using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerApp.Shared.Models;

namespace TaskManagerApp.Shared.JsonResponse
{
    public class TaskListResponse
    {
        public List<TaskItem> TaskIList { get; set; }
    }
}
