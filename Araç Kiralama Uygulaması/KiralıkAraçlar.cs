using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Kiralama_Uygulaması;

public class KiralikAraclar
{

    public KiralikAraclar(string marka, int model, int gunlukFiyat)
    {
        Marka = marka;
        Model = model;
        GunlukFiyat = gunlukFiyat;
    }
    public string Marka { get; set; }
    public int Model { get; set; }   
    public int GunlukFiyat { get; set; }



    
}
