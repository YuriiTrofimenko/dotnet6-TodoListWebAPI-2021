using System;
using System.Collections.Generic;
using System.Linq;
using TodoListWebAPI.Models;

namespace TodoListWebAPI.Services
{
    public class TodosInMemoryRepository : ITodosRepository
    {
        private static readonly List<ToDoItem> ITEMS =
            new()
            {
                new("t1", "d1", new DateTime()),
                new("t2", "d2", new DateTime()),
                new("t3", "d3", new DateTime())
            };
        public IQueryable<ToDoItem> Items => ITEMS.AsQueryable();

        public bool update(long id, ToDoItem newItem)
        {
            var item = ITEMS.SingleOrDefault(oldItem => oldItem.Id == id);
            Console.WriteLine(id);
            ITEMS.ForEach(Console.WriteLine);
            if (item != null)
            {
                item.Title = newItem.Title;
                item.Done = newItem.Done;
                return true;
            }
            return false;
        }
    }
}