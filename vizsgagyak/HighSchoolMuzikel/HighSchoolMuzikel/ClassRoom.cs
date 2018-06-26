using System;
using System.Collections.Generic;
using System.Text;

namespace HighSchoolMuzikel
{
    class ClassRoom
    {
        private List<Event> events;
        private int mess;

        public int Mess { get => mess; set => mess = value; }
        public List<Event> Events { get => events; set => events = value; }

        public ClassRoom()
        {
            Events = new List<Event>();
            Mess = 0;
        }
        public void AddEvent(Event stuff)
        {
            events.Add(stuff);
        }

    }
}
