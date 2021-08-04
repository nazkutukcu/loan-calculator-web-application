using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj.Models
{
    public class Class1
    {
        public int sayi { get; set; }
        public string isim { get; set; }

        public int currentVal { get; set; }

    }
    
    public class DataList
    {
        public List<Class1> Class11 { get; set; } = null;

        public DataList()
        {
            Class11 = new List<Class1>();
            Class1 cs = new Class1();
            cs.sayi = 1001;
            cs.isim = "Naz";
            Class11.Add(cs);
        }
    }
   
}
    