using Application.Todos.Shared;

namespace Application.Todos.GetTodos;
public class GetTodosQueryHandler(TodoService todoService)
{
    public GetTodosQueryResponse Handle(GetTodosQuery query)
    {
        var result = todoService.Find();
        return new GetTodosQueryResponse(result);
    }
}