using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    public class DummyKişiMapper : IMapper
    {
        DummyTaşıyıcıMapper tm ;
        DummyMüşteriMapper mm ;
        public DummyKişiMapper()
        {
            tm = new DummyTaşıyıcıMapper();
            mm = new DummyMüşteriMapper();
        }

        public object Get(int OID)
        {
            throw new NotImplementedException();
        }

        public void Put(object obj)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAll()
        {
            return  mm.GetAll()
                .Concat(tm.GetAll())
                .ToList();
        }
    }
}
