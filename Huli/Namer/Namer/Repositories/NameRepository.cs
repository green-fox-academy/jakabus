using Namer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Namer.Repositories
{
    public class NameRepository
    {
        private NameContext names;

        public NameRepository(NameContext names)
        {
            this.names = names;
        }

        //CRUD

        public void Create(Name name)
        {
            names.Names.Add(name);
            names.SaveChanges();
        }
        
        public List<Name> ReadNames()
        {
            return names.Names.ToList();
        }

        public void Update(Name name)
        {
            names.Names.Update(name);
            names.SaveChanges();
        }

        public void Delete(Name name)
        {
            names.Names.Remove(name);
            names.SaveChanges();
        }
    }
}
