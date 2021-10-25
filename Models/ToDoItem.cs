using System;

namespace TodoListWebAPI.Models
{
    public class ToDoItem
    {
        private static long lastId = 0;
        public long id;
        public string title;
        public string description;
        public DateTime date;
        public bool done;
        public ToDoItem (string title, string description, DateTime date, long id = 0, bool done = false) {
            if(id == 0)
            {
                this.id = ++ToDoItem.lastId;
            } else
            {
                this.id = id;
            }
            this.title = title;
            this.description = description;
            this.date = date;
            this.done = done;
        }
    }
}