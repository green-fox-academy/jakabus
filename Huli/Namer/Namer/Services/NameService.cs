using Namer.Models;
using Namer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Namer.Services
{
    public class NameService
    {
        private NameRepository nameRepo;

        public NameService(NameRepository nameRepo)
        {
            this.nameRepo = nameRepo;
        }

        public void AddName(Name name)
        {
            nameRepo.Create(name);
        }

        public List<Name> GetNames()
        {
            return nameRepo.ReadNames();
        }

        public void UpdateName(Name name)
        {
            nameRepo.Update(name);
        }

        public void DeleteName(int id)
        {
            Name name = nameRepo.ReadNames().Where(i => i.Id == id).First();
            nameRepo.Delete(name);
        }

        public void NameIt(string firstname, string lastname)
        {
            Name name = new Name { FirstName = firstname, LastName = lastname };
            AddName(name);            
        }

    }
}
