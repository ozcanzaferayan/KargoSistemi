using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    public class DummyAçıkEksiltmeMapper : IMapper
    {
        private AçıkEksiltme açıkEksiltme;
        public object Get(int OID)
        {
            return this.açıkEksiltme;
        }

        public void Put(object obj)
        {
            açıkEksiltme = (AçıkEksiltme)obj;
        }



        public List<String> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
