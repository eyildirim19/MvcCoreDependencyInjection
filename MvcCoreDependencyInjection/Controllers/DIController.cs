using Microsoft.AspNetCore.Mvc;
using MvcCoreDependencyInjection.Models;

namespace MvcCoreDependencyInjection.Controllers
{
    public class DIController : Controller
    {
        //private readonly IInsan insan = new Ogrenci();

        private readonly IInsan insan;
        public DIController(IInsan _insan)
        {
            //  insan = new Ogrenci(); // instance program.cs dosyasından gönderilecek..
            insan = _insan;
        }

        public IActionResult Index()
        {
            //  insan = new Ogrenci(); => readonly fieldlar sadece constructorlarda instance alınabilir..
            string str = insan.Dusunce();

            // return View("asda");
            //return View(str); // NOT :MODELİN TİPİ HER ŞEY OLABİLİR. ANCAK VİEW PARAMETRESİNDE İLK PARAMETRE VİEWNAME OLDĞU İÇİN EĞER STRİNG MODEL VERİRSENİZ O MODELİ VİEWNAME OLARAK ALGILAR...

            // eğer string model varsa, ilk parametre ile viewname, ikinci parametre ile model gönderilmelidir
            return View("Index", str);
        }
    }
}