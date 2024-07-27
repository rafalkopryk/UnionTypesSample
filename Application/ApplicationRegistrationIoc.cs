using Application.Todos.GetTodo;
using Application.Todos.GetTodos;
using Application.Todos.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ApplicationRegistrationIoc
{
    public static void AddApplication(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<TodoService>();
        serviceCollection.AddSingleton<GetTodoQueryHandler>();
        serviceCollection.AddSingleton<GetTodosQueryHandler>();
    }
}