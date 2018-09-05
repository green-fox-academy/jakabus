using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class InjectionClass
    {
        private TodoContext todoContext;

        public InjectionClass(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }
    }
}
