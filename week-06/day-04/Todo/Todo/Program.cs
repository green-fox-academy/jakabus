using System;
using System.Collections.Generic;
using Todo;

namespace Todo
{
    class Program
    {
        private static List<TodoClass> todos = new List<TodoClass>();

        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                todos.Add(new TodoClass(i, "asd", DateTime.Now));
            }
        }

        private static void Add(TodoClass todo)
        {
            todos.Add(todo);
        }
    }
}
