using System;

namespace TodoListWebAPI.Models
{
    public class ToDoItem
    {
        private static long _lastId = 0;
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Done { get; set; }
        public ToDoItem (string title, string description, DateTime date, long id = 0, bool done = false) {
            if(id == 0)
            {
                Id = ++_lastId;
            } else
            {
                Id = id;
            }
            Title = title;
            Description = description;
            Date = date;
            Done = done;
        }

        public override string ToString()
        {
            return $"ToDoItem: Id = {Id}, Title = {Title}, Date = {Date}, Done = {Done}";
        }
    }
}