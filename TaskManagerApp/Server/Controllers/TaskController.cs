using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskManagerApp.Server.Data;
using TaskManagerApp.Shared.Models;

namespace TaskManagerApp.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly DatabaseContext? _ctx;

        public TaskController(DatabaseContext ctx)
        {
            _ctx = ctx;

        }

       [HttpPost]
public IActionResult AddTask(TaskItem task)
{
    var status = new Status();

    if (!ModelState.IsValid)
    {
        status.StatusCode = 0;
        status.Message = "Please pass valid data";
        return Ok(status);
    }

    try
    {
        if (task.Id == 0)
            _ctx.Task.Add(task);
        else
            _ctx.Task.Update(task);

        _ctx.SaveChanges();

        status.StatusCode = 1;
        status.Message = "It was successfully updated.";
    }
    catch (Exception)
    {
        status.StatusCode = 0;
        status.Message = "It failed to update.";
    }

    return Ok(status);
}



        [HttpDelete("DeleteAll")]

        public IActionResult DeleteTask()
        {
            var status = new Status();
            var task = _ctx.Task.Where(t => t.IsCompleted == true).ToList();
            if (task.Count == 0)
            {
                status.StatusCode = 0;
                status.Message = "No complete task found";

            }
            _ctx.Task.RemoveRange(task);
            _ctx.SaveChanges();
            status.StatusCode = 1;
            status.Message = "Tasks completely deleted.";
            return Ok(status);
        }


        [HttpDelete("{id}")]

        public IActionResult DeleteTask(int id)
        {
            var status = new Status();
            var person = _ctx.Task.Find(id);
            if (person is null)
            {
                status.StatusCode = 0;
                status.Message = "Can not be found.";
            }
            _ctx.Task.Remove(person);
            _ctx.SaveChanges();
            status.StatusCode = 1;
            status.Message = "the delete was a success.";
            return Ok(status);
        }





        [HttpGet("{id}")]
        public IActionResult GetTaskById(int id)
        {
            var task = _ctx.Task.Find(id);
            return Ok(task);
        }

        [HttpGet]
        public IActionResult GetTaskAll()
        {
            var status = new Status();
            var tasks = _ctx.Task.ToList();
            var model = new TaskList
            {
                Tasklist = tasks
            };
            return Ok(model);
        }

    }
}
