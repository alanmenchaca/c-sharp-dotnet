// dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0
// dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 9.0.0
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.0
// dotnet watch run

using dotnet_ef;
using dotnet_ef.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string? connStr = builder.Configuration.GetConnectionString("TasksManagerDB");
builder.Services.AddSqlServer<TasksManagerContext>(connStr);
/*builder.Services.AddDbContext<TasksManagerContext>(
    /*El método UseInMemoryDatabase se utiliza para especificar que se debe usar
    una base de datos en memoria en lugar de una base de datos en disco. Esto puede
    ser útil para fines de prueba o para aplicaciones con una cantidad limitada de
    datos que no requieren una base de datos persistente.#1#
    p => p.UseInMemoryDatabase("TasksManagerDB")
);*/

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGet("/dbConnection", EnsureDatabaseCreated);
app.MapGet("/api/tasks", GetTasksWithCategory);
app.MapPost("/api/tasks", PostTask);
app.MapPut("/api/tasks/{taskId}", UpdateTask);
app.MapDelete("api/tasks/{taskId}", DeleteTask);
app.Run();
return;

Task<IResult> EnsureDatabaseCreated([FromServices] TasksManagerContext context)
{
    context.Database.EnsureCreated();
    return Task.FromResult(Results.Ok($"Database created: {context.Database.IsInMemory()}"));
}

IResult GetTasksWithCategory([FromServices] TasksManagerContext context)
{
    var tasks = context.Tasks.Include(t => t.Category);
    return Results.Ok(tasks);
}

async Task<IResult> PostTask(
    [FromServices] TasksManagerContext context,
    [FromBody] Tasks tasks)
{
    tasks.TaskId = Guid.NewGuid();
    tasks.CreatedAt = DateTime.Now;

    await context.Tasks.AddAsync(tasks);
    await context.SaveChangesAsync();
    return Results.Ok(tasks);
}

async Task<IResult> UpdateTask(
    [FromServices] TasksManagerContext context,
    [FromBody] Tasks tasks,
    [FromRoute] Guid taskId)
{
    var currentTask = context.Tasks.Find(taskId);
    if (currentTask == null) return Results.NotFound();

    currentTask.CategoryId = tasks.CategoryId;
    currentTask.Title = tasks.Title;
    currentTask.Priority = tasks.Priority;
    currentTask.Description = tasks.Description;

    await context.SaveChangesAsync();
    return Results.Ok();
}

async Task<IResult> DeleteTask(
    [FromServices] TasksManagerContext context,
    [FromRoute] Guid taskId)
{
    var currentTask = context.Tasks.Find(taskId);
    if (currentTask == null) return Results.NotFound();

    context.Tasks.Remove(currentTask);
    await context.SaveChangesAsync();
    return Results.Ok();
}