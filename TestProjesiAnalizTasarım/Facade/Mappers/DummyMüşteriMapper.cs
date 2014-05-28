using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjesiAnalizTasarım.Kişiler;
namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    public class DummyMüşteriMapper : IMapper
    {
        private static List<String> müşterilerOutput;
        private static Dictionary<int, Müşteri> müşteriler;
        public DummyMüşteriMapper()
        {
            if (müşterilerOutput == null)
            {
                müşterilerOutput = new List<string>();
            }
            if (müşteriler == null)
            {
                müşteriler = new Dictionary<int, Müşteri>();
            }
        }
        public object Get(int OID)
        {
            try
            {
                return müşteriler[OID];
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        public void Put(object obj)
        {
            Müşteri m = obj as Müşteri;
            müşterilerOutput.Add(m.ToString());
            müşteriler.Add(m.OID, m);
        }

        public List<String> GetAll()
        {
            return müşterilerOutput;
        }
    }
}
