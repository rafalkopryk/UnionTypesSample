using Application.Todos.Shared;

namespace Application.Todos.GetTodo;

public record GetTodoQuery(int Id);

/// <summary>
/// https://github.com/dotnet/csharplang/blob/main/proposals/TypeUnions.md#implementation
/// https://youtu.be/l44Y6lNmNZ0?t=3404
/// https://youtu.be/7glPhme1Vek?t=948
/// 
/// public union GetTodoQueryResponse
/// {
///     public case Ok(Todo Todo);
///     public case NotFound;
/// }
/// </summary>
public abstract record GetTodoQueryResponse
{
    public record Ok(Todo Todo) : GetTodoQueryResponse;
    public record NotFound : GetTodoQueryResponse
    {
        public static readonly NotFound Result = new();
    };
}