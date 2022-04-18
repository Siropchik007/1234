using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassMainRep
    {
        private ClassRep rep1;

        public ClassMainRep (ClassRep rep2)
        {
            rep1 = rep2;
        }

        public List<Class1> GetAllList()
        {
            return rep1.listapp.ToList();
        }

        public void Delete(int dl)
        {
            var deletelist = rep1.listapp.FirstOrDefault(x => x.Id == dl);
            rep1.listapp.Remove(deletelist);
        }
    }
}
