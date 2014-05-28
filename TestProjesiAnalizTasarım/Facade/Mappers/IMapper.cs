using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    public interface IMapper
    {
        Object Get(int OID);
        void Put(Object obj);

        List<String> GetAll();
    }
}
