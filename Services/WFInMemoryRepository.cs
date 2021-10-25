using System;
using System.Collections.Generic;
using System.Linq;
using TodoListWebAPI.Models;

namespace TodoListWebAPI.Services
{
    public class WFInMemoryRepository : IWFRepository
    {
        public IQueryable<ToDoItem> Items =>
            new List<ToDoItem>()
            {
                new ToDoItem("t1", "d1", new DateTime()),
                new ToDoItem("t2", "d2", new DateTime()),
                new ToDoItem("t3", "d3", new DateTime())
            } as IQueryable<ToDoItem>;
        
    }
}