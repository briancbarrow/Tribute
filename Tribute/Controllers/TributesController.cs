using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tribute.Data;
using Tribute.Models;

namespace Tribute.Controllers
{
    public class TributesController : Controller
    {
        private TributeRepository _tributeRepository = null;

        public TributesController()
        {
            _tributeRepository = new TributeRepository();
        }

        public ActionResult Index()
        {
            var tributes = _tributeRepository.GetTributes();

            return View(tributes);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var tribute = _tributeRepository.GetTribute((int)id);
            
            return View(tribute);
        }
    }
}