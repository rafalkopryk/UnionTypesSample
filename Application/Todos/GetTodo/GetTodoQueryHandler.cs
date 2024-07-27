using Application.Todos.Shared;
using static Application.Todos.GetTodo.GetTodoQueryResponse;

namespace Application.Todos.GetTodo;

public class GetTodoQueryHandler(TodoService todoService)
{
    public GetTodoQueryResponse Handle(GetTodoQuery query)
    {
        var result = todoService.Find(query.Id);
        return result is null
            ? NotFound.Instance
            : new Ok(result);
    }
}