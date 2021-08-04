using BusinessLayer.Interface;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using Staj.Models;
//using Sunum.Models;


namespace BusinessLayer
{
    public class KrediHesaplama : IKrediHesaplama
    {


        public int KrediHesap(int KrediTutari)
        {
            int deneme = KrediTutari / 2;
            return deneme;
        }


        public List<Vade> VadeHesapla(decimal KrediTutari, int KrediVadesi)
        {

            decimal TaksitTutari = KrediTutari / KrediVadesi;

            List<Vade> VadeListesi = new List<Vade>();

            decimal birOncekiAnapara = 0;

            for (int i = 0; i < KrediVadesi + 1; i++)
            {
                if (i == 0)
                {
                    Vade vadem = new Vade();
                    vadem.TaksitTutari = 0;
                    vadem.AnaPara = KrediTutari;

                    VadeListesi.Add(vadem);
                }
                else if (i == 1)
                {
                    Vade vadem = new Vade();
                    vadem.TaksitTutari = TaksitTutari;
                    vadem.AnaPara = KrediTutari - vadem.TaksitTutari;

                    birOncekiAnapara = vadem.AnaPara;

                    VadeListesi.Add(vadem);
                }
                else
                {
                    Vade vadem = new Vade();
                    vadem.TaksitTutari = TaksitTutari;
                    vadem.AnaPara = birOncekiAnapara - vadem.TaksitTutari;

                    birOncekiAnapara = vadem.AnaPara;

                    VadeListesi.Add(vadem);
                }
            }

            return VadeListesi;
        }




    }
}
