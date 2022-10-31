using Microsoft.EntityFrameworkCore;
using Wallet.NFT.Domain;
using Wallet.NFT.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
/*
app.MapPost("/lancamento", (Lancamento lancamento, ILancamentoService lancamentoService) =>
        !MiniValidator.TryValidate(lancamento, out var errors)
            ? Results.ValidationProblem(errors)
            : Results.Ok(lancamentoService.Create(lancamento)));
*/
app.MapGet("/", () => "Abertura de caixa.");

app.MapPost("/lancamento", async (Todo todo, TodoDb db) =>
{
    db.Todos.Add(todo);
    await db.SaveChangesAsync();
    return Results.Created($"/todoitems/{todo.Id}", todo);
});



app.Run();
class Todo
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}

class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}

public partial class Program { }