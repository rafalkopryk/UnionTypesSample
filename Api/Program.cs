using System.Text.Json.Serialization;
using Application;
using Application.Todos.GetTodo;
using Application.Todos.GetTodos;
using Application.Todos.Shared;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

builder.Services.AddApplication();

var app = builder.Build();

var todosApi = app.MapGroup("/todos");
todosApi.MapGet("/", (GetTodosQueryHandler handler) =>
{
    var result = handler.Handle(new GetTodosQuery());
    return Results.Ok(result.Todos);
});

todosApi.MapGet("/{id}", (int id, GetTodoQueryHandler handler) =>
{
    var result = handler.Handle(new GetTodoQuery(id));
    return result switch
    {
        GetTodoQueryResponse.Ok(Todo todo) => Results.Ok(todo), //or GetTodoQueryResponse.Ok ok => Results.Ok(ok.Todo),
        GetTodoQueryResponse.NotFound => Results.NotFound(),
        _ => Results.StatusCode(500),
    };
});

app.Run();

[JsonSerializable(typeof(Todo[]))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}