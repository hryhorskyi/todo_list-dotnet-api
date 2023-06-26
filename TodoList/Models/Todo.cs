using System;
using System.Collections.Generic;

namespace TodoList.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
        public List<Todo>? SubTodos { get; set; }  // Nested list of Todo items
    }
}
