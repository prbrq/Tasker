using Microsoft.AspNetCore.Mvc;

namespace Tasker.Controllers;

public class TaskController(TaskerContext context) : Controller
{
    [HttpGet]
    public IActionResult GetTasks()
    {
        var tasks = context.Tasks.ToList();

        return Ok(tasks);
    }

    [HttpPost]
    public IActionResult InsertTask()
    {
        var newTask = new Models.Task()
        {
            Text = "TaskText"
        };
        context.Tasks.Add(newTask);
        context.SaveChanges();

        return Ok(newTask.Id);
    }
}