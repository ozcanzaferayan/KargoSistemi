using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjesiAnalizTasarım.Kişiler;

namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    public class DummyTaşıyıcıMapper : IMapper
    {
        public static List<String> taşıyıcılarOutput;
        private static Dictionary<int, Taşıyıcı> taşıyıcılar;
        public DummyTaşıyıcıMapper()
        {
            if (taşıyıcılarOutput == null)
            {
                taşıyıcılarOutput = new List<string>();
            }
            if (taşıyıcılar == null)
            {
                taşıyıcılar = new Dictionary<int, Taşıyıcı>();
            }
            
        }
        public object Get(int OID)
        {
            try
            {
                return taşıyıcılar[OID];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Put(object obj)
        {
            Taşıyıcı t = obj as Taşıyıcı;
            taşıyıcılarOutput.Add(t.ToString());
            taşıyıcılar.Add(t.OID, t);
        }
        public List<String> GetAll()
        {
            return taşıyıcılarOutput;
        }
    }
}
