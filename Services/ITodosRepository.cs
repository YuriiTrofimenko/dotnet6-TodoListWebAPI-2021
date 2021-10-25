using System.Linq;
using TodoListWebAPI.Models;

namespace TodoListWebAPI.Services
{
    public interface ITodosRepository
    {
        IQueryable<ToDoItem> Items { get; }
        bool update(long id, ToDoItem item);
    }
}