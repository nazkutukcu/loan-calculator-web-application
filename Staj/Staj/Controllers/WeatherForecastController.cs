using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Staj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Interface;
using NPOI.SS.Formula.Functions;
using Staj;
using InventivCore;
using InventivCore.Models;

namespace Staj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
      {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet]

        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();


        }



        [HttpPost]

        public List<DTOOdemePlani> PostOdemePlani(DTOOdemePlani dTOOdemePlani)
        {
            List<DTOOdemePlani> policeOdemePlani = new List<DTOOdemePlani>();

            KrediHesaplama obj = new KrediHesaplama();
            


            var deneme = obj.KrediHesap(dTOOdemePlani.KrediTutari);

            policeOdemePlani.Add(new DTOOdemePlani()
            {
                KrediTutari = dTOOdemePlani.KrediTutari,
                KrediVadesi = dTOOdemePlani.KrediVadesi,
                deneme = deneme,



            });


            
            return policeOdemePlani;



        }
        [HttpPost("useradd")]
        public IActionResult UserAdd(User user)
        {
            InventivContext bb = new InventivContext();
            bb.Add(user);
            return Ok(user);
        }
        /*
        [HttpGet]
        public int helloworld()
        {
            KrediHesaplama obj = new KrediHesaplama();
            int sayhello = obj.KrediHesap();
            return sayhello;
        }

        */


        //decimal KrediTutari,

        [HttpPost("odemeplani")]
        public IActionResult OdemePlaniAdd(decimal KrediTutari,int KrediVadesi)
        {

           
            KrediHesaplama hesapla = new KrediHesaplama();

           var gelenListe=  hesapla.VadeHesapla(KrediTutari, KrediVadesi);

            InventivContext db = new InventivContext();


            db.HesaplananVadeEkle(gelenListe);

            return Ok(gelenListe);
        }
        [HttpGet("getallvade")]
        public IActionResult GetAllVade()
        {
            InventivContext db = new InventivContext();
            var result = db.GetAllVade();
            return Ok(result);
        }
        //şimdi size yağtıgımı anlataym
        //1.ANGULARDAN 5000 VE 5 GİBİ İK DEĞER GELECEK BURAYA.
        //BURAYA VADE HESAPLA METODUNUZ GİDİP LİSTE LİSTE YAPACAK VE DÖNECEK ODA GELENLİSTE İÇİN DOLU VAR SATIRLAR OLUŞMUŞ.
        //DAHA SONRA HesaplananVadeEkle BU METOD LİSTE İSTIYOR YA GELEN LİSTEYİ VERİYORUZ ICINE
        //GORDUN MU SONRADA TEK TEK LISTEYI SQL E EKLEYECEK OLAY BU
       

      
    }


}



