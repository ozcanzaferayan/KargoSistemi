using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    class DummyÜrünMapper : IMapper
    {
        Ürün ü;

        public object Get(int OID)
        {
            return this.ü;
        }

        public void Put(object obj)
        {
            this.ü = (Ürün)obj;
        }

        public List<String> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
