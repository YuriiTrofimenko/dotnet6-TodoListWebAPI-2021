using System.Linq;
using TodoListWebAPI.Models;

namespace TodoListWebAPI.Services
{
    public class IWFRepository
    {
        public IQueryable<ToDoItem> Items { get; }
    }
}