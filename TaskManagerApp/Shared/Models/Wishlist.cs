using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp.Shared.Models
{
    public class Wishlist
    {
        public List<TaskItem> WishItems { get; set; } = new List<TaskItem>();
    }
}
