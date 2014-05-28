using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjesiAnalizTasarım.Facade.Mappers;
using TestProjesiAnalizTasarım.Kişiler;
using TestProjesiAnalizTasarım.ÜrünBilgileri;

namespace TestProjesiAnalizTasarım.Facade
{
    public class DBFacade
    {
        private Dictionary<Type, IMapper> mappers;
        private static DBFacade facade;
        private DBFacade()
        {
            mappers = new Dictionary<Type, IMapper>
            {
                { typeof(Müşteri), new DummyMüşteriMapper() },
                { typeof(Teklif), new DummyTeklifMapper() },
                { typeof(Ürün), new DummyÜrünMapper() },
                { typeof(ÜrünDescription), new DummyÜrünDescriptionMapper() },
                { typeof(Kargoİşi), new DummyKargoİşiMapper() },
                { typeof(Taşıyıcı), new DummyTaşıyıcıMapper() },
                { typeof(AçıkEksiltme), new DummyAçıkEksiltmeMapper() },
                { typeof(MüşterininTaşıyıcıyıSeçmesi), new DummyMüşterininTaşıyıcıyıSeçmesiMapper() },
                { typeof(Kişi), new DummyKişiMapper() },
            };
        }
        public static DBFacade GetInstance()
        {
            if (facade == null)
            {
                return new DBFacade();
            }
            else
            {
                return facade;
            }
        }

        public Object Get(int OID, Type persistenceClass)
        {
            IMapper mapper = mappers[persistenceClass];
            return mapper.Get(OID);
        }


        public void Put(Object obj, Type persistenceClass)
        {
            mappers[persistenceClass].Put(obj);
        }

        public List<String> GetAll(Type persistenceClass)
        {
            return mappers[persistenceClass].GetAll();
        }
    }
}
