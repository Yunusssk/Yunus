using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Kiralama_Uygulaması;

public class AracKonumu
{
    public double Enlem {  get; set; }
    public double Boylam { get; set; }
    public AracKonumu(double enlem, double boylam) 
    {
        Enlem = enlem;
        Boylam = boylam;    
    }
}
