using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    public class DummyÜrünDescriptionMapper:IMapper
    {
        ÜrünDescription üd;

        public object Get(int OID)
        {
            return üd;
        }

        public void Put(object obj)
        {
            this.üd = (ÜrünDescription)obj;
        }




        public List<String> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
