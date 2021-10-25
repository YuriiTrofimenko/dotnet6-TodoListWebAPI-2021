using System;
using System.Collections.Generic;
using System.Linq;
using TodoListWebAPI.Models;

namespace TodoListWebAPI.Services
{
    public class TodosInMemoryRepository : ITodosRepository
    {
        public IQueryable<ToDoItem> Items =>
            new List<ToDoItem>
            {
                new("t1", "d1", new DateTime()),
                new("t2", "d2", new DateTime()),
                new("t3", "d3", new DateTime())
            }.AsQueryable();
        
    }
}