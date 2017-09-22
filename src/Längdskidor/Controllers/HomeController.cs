using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Längdskidor.Models;

namespace Längdskidor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(float length,int age,bool barn04,bool barn58,bool Isklass,string info)
        {
           
            var skidor = new skidor();
            skidor.Length = length;
            skidor.Age = age;
            skidor.Barn04 = barn04;
            skidor.Barn58 = barn58;
            skidor.IsKlass = Isklass;
            skidor.Info = info;
            
             
            
            if (skidor.Barn04)
            {
                skidor.Skidlangd = skidor.Length;

            }
            else if (skidor.Barn58)
            {

                skidor.Skidlangd = skidor.Length + 10;
                var maxSkidlangd = skidor.Skidlangd + 20;
                skidor.Info = "Kroppslängd från " + skidor.Skidlangd +" till " + maxSkidlangd;

            }
            //age has to be more than 8 years 
            else if (skidor.Age > 8 && skidor.IsKlass == true && skidor.Length <= 207)
            {
                skidor.Skidlangd = skidor.Length + 20;
                skidor.Info = "Klassiska skidor tillverkas bara till längder upp till 207cm.";

            } else if(skidor.Length > 207)
            {
                skidor.Info = "Klassiska skidor tillverkas bara till längder upp till 207cm.";

            }

            else if (skidor.Age > 8 && skidor.IsKlass == false)
            {
                skidor.Skidlangd = skidor.Length + 10;
                var maxSkidlangd = skidor.Skidlangd + 15;
                skidor.Info = "Kroppslängd från " + skidor.Skidlangd + " till " + maxSkidlangd + " Enligt tävlingsreglerna får inte skidan understiga kroppslängden med mer än 10cm.";
                

            }

            return View(skidor);
        }


        public IActionResult Error()
        {
            return View();
        }

      
    }
}
