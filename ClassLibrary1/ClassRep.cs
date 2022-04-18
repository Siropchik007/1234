using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassRep
    {
       public List<Class1>  listapp;

        public ClassRep()
        {
            listapp = new List<Class1>()
            {
                new Class1(){ Id = 12, Name = "Imya"},
                new Class1(){ Id = 13, Name = "Imya2"},
                new Class1(){ Id = 14, Name = "Imya3"}
            };

        }
    }
}
