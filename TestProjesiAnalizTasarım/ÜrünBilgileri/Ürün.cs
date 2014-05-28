using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım.ÜrünBilgileri
{
    public class Ürün : IDisposable
    {
        public int OID;
        public Ürün()
        {
            this.OID = IDGenerator.GetÜrünID();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
