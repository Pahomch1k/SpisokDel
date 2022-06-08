using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisokDel
{
    class CTemaZvuk
    {
        private int tema;

        private int zvuk;

        private static CTemaZvuk obj;

        private CTemaZvuk()
        {
            tema = 0;
            zvuk = 0;
        }

        static CTemaZvuk()
        {
            obj = new CTemaZvuk(); 
        }
         
        public static int GetZvuk()
        {
            return obj.zvuk;
        }

        public static int GetTema()
        {
            return obj.tema;
        }

        public static void SetTema(int x)
        {
            obj.tema = x;
        }
        public static void SetZvuk(int x)
        {
            obj.zvuk = x;
        }
    } 
} 