using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Services
{
    //This is the interface where the CRUD operations will be handeled in organized way.
    //This is for the UserLogin Repository
    public interface IClinic<T>
    {
        void Add(T t);
        void Update(int id, T t);
        void Delete(T t);
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
