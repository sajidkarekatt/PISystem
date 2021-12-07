using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIClassLibrary
{
    public interface IPersonalDataManipulation<T>
    {
        public void Save(T patient);
        public T? Retrieve(string id);
        public void Delete(string id);
        public List<T>? RetrieveAll();
    }
}
