using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp.Shared.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;

        public string Organization { get; set; } = "personal";
        public DateTime? Deadline { get; set; } = DateTime.Today.AddDays(1).Add(new TimeSpan(0, 0, 0));

        public bool IsActive { get; set; } = true;

    }
}
