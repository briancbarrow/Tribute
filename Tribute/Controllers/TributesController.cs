using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tribute.Models;

namespace Tribute.Controllers
{
    public class TributesController : Controller
    {
        public ActionResult Detail()
        {
            var tribute = new SingleTribute()
            {
                TributeTitle = "His Holiness The Dalai Lama",
                BioDescriptionHtml = "<p>Tenzin Gyatso is the current and 14th Dalai Lama</p>",
                BioDates = new BioDate[]
                {
                    new BioDate() { Year = "1935", Event = "Born in Taktser village, Amdo, Tibet." },
                    new BioDate() { Year = "1937", Event = "Selected as the successor of the 13th Dalai Lama" },
                    new BioDate() { Year = "1939", Event = "Formally recognized as the 14th Dalai Lama" },
                    new BioDate() { Year = "1950", Event = "Assumed full temporal/political duties" },
                    new BioDate() { Year = "1959", Event = "Fled to India" },
                    new BioDate() { Year = "1989", Event = "Received Nobel Peace Prize" },
                },
                ImageLink = "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwjtirWiwM_UAhXBmpQKHebmBs0QjRwIBw&url=http%3A%2F%2Fwww.newsweek.com%2Fi-am-marxist-says-dalai-lama-299598&psig=AFQjCNGsQ3BXL0vc0O7BZUyETflJwOU26Q&ust=1498153868280253",
                ExternalLink = "https://en.wikipedia.org/wiki/14th_Dalai_Lama"
            };
            
            return View(tribute);
        }
    }
}