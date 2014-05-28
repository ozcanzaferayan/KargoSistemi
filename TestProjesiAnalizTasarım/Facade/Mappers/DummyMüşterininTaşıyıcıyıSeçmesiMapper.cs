using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    public class DummyMüşterininTaşıyıcıyıSeçmesiMapper : IMapper
    {
        MüşterininTaşıyıcıyıSeçmesi mts;
        public object Get(int OID)
        {
            return this.mts;
        }

        public void Put(object obj)
        {
            mts = obj as MüşterininTaşıyıcıyıSeçmesi;
        }




        public List<String> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
