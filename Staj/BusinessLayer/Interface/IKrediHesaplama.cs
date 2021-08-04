using Staj.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IKrediHesaplama
    {
        int KrediHesap(int KrediTutari);
        //List<Vade> VadeHesapla(decimal KrediTutari, int KrediVadesi);
        List<Vade> VadeHesapla(decimal KrediTutari, int KrediVadesi);

       // List<DTOOdemePlani> KayitListe(string sqlCumlesi);
    }
}
