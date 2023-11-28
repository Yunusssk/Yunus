using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Kiralama_Uygulaması;

public class AracKiralayanKisiler
{
    public string Isim { get; set; }
    public int Yas { get; set; }
    public int TC { get; set; }

    public AracKiralayanKisiler(string isim, int yas, int tc) 
    { 
        Isim = isim;
        Yas = yas;
        TC = tc;
    }
}
