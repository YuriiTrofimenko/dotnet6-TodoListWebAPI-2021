using System.Linq;
using TodoListWebAPI.Models;

namespace TodoListWebAPI.Services
{
    public class IWFRepository
    {
        IQueryable<ToDoItem> Items { get; }
    }
}