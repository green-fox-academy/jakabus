using System;
using System.Collections.Generic;
using System.Text;

namespace Todo
{
    public class TodoClass
    {
        private int id;
        private string text;
        private DateTime dateTime;

        public TodoClass(int id, string text, DateTime dateTime)
        {
            this.Id = id;
            this.Text = text;
            this.DateTime = dateTime;
        }

        public int Id { get => id; set => id = value; }
        public string Text { get => text; set => text = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
    }
}
