using Application.Todos.Shared;

namespace Application.Todos.GetTodos;

public record GetTodosQuery();

public record GetTodosQueryResponse(Todo[] Todos);