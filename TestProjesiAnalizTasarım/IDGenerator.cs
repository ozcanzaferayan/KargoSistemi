using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjesiAnalizTasarım
{
    public class IDGenerator
    {
        private static int kargoİşiID = 0;
        private static int ürünID = 0;
        private static int teklifID = 0;
        private static int kişiID = 0;

        internal static int GetÜrünID()
        {
            return ürünID++;
        }

        internal static int GetKargoİşiID()
        {
            return kargoİşiID++;
        }

        internal static int GetTeklifID()
        {
            return teklifID++;
        }

        internal static int GetKişiID()
        {
            return kişiID++;
        }
    }
}
