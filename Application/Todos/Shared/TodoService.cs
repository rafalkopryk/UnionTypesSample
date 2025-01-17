﻿namespace Application.Todos.Shared;

public class TodoService
{
    private readonly Todo[] _sampleTodos = [
        new(1, "Walk the dog"),
        new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
        new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
        new(4, "Clean the bathroom"),
        new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
    ];

    public Todo? Find(int id) => _sampleTodos.FirstOrDefault(x => x.Id == id);

    public Todo[] Find() => _sampleTodos;    
}