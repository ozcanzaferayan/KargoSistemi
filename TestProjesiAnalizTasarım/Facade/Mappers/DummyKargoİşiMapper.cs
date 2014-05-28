using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.Facade.Mappers
{
    public class DummyKargoİşiMapper : IMapper
    {

        public static Dictionary<int, Kargoİşi> kargoİşleri;
        public static List<String> kargoİşleriOutput;
        public DummyKargoİşiMapper()
        {
            kargoİşleri = new Dictionary<int, Kargoİşi>();
            kargoİşleriOutput = new List<string>();
        }
        public object Get(int OID)
        {
            try
            {
                return kargoİşleri[OID];
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public void Put(object obj)
        {
            Kargoİşi k = obj as Kargoİşi;
            kargoİşleri.Add(k.ID, k);
            kargoİşleriOutput.Add(k.ToString());
        }

        public List<String> GetAll()
        {
            return kargoİşleriOutput;
        }
    }
}
