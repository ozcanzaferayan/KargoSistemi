using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjesiAnalizTasarım.Kişiler;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    public class DummyTeklifMapper: IMapper
    {
        Teklif t;
        public object Get(int OID)
        {
            return t;
        }

        public void Put(object obj)
        {
            t = (Teklif)obj;
        }



        public List<String> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
