using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Kiralama_Uygulaması;

public class Arac
{
    public string Marka {  get; set; }
    public int Model { get; set; }
    public int GunlukKira { get; set; }

    public Arac(string marka, int model, int gunlukKira) 
    {
        Marka = marka;
        Model = model;
        GunlukKira = gunlukKira;
    }
    public void Yazdir()
    {
        Console.WriteLine(Marka + "," + Model);
    }
}
