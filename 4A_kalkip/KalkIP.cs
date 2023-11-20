using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A_kalkip
{
    internal class KalkIP
    {
        private uint _AdresIP = 0;
        private uint _MaskaSieci = 0;
        private int _MaskaWartosc = 0; // 0 ... 32;
        public uint AdresIP { get { return _AdresIP; } 
                              set { _AdresIP = value;  } }
        public  uint MaskaSieci { get { return _MaskaSieci; }
            set {
                _MaskaSieci = SprawdzMaske(value);
            }
        }
        public uint AdresSieci
        {
            get { return _AdresIP & _MaskaSieci; }
        }

        public uint AdresRozgloszeniowy
        {
            get { return AdresSieci | (0xffffffff & ~(_MaskaSieci)); }
        }
        public uint PierwszyAdresSieci { get { return AdresSieci + 1; } }
        public uint OstatniAdresSieci { get { return AdresRozgloszeniowy - 1; } }
        public uint LiczbaHostowWSieci { get { return OstatniAdresSieci - AdresSieci; } }
        protected uint SprawdzMaske(uint maska)
        {
         
            uint m = ~maska;
           while((m & 1)>0)
            {
                m >>= 1;
            }
           if(m>0)
                throw new Exception("Podana maska jest błędna");
       
            return maska;
        }

    }
}
