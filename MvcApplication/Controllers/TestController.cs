using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library2;

namespace MvcApplication.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            using (var context = new Context())
            {
                var messages = context.Message.ToList();
            }

            return new EmptyResult();
        }

    }
}
