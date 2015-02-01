using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Reaxml.Common;

namespace Reaxml.Controllers
{
    public class ValidatorController : Controller
    {
        public ActionResult Index()
        {
            return View("Home");
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Validate(string xml)
        {
            var binFolderPath = Server.MapPath("~/bin");
            var path = Path.Combine(binFolderPath, "reaxml.xsd");
            var serializer = new Serializer(path);

            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                try
                {
                    var stopWatch = Stopwatch.StartNew();

                    var results = serializer.Serialize(memoryStream);

                    return Json(new
                    {
                        Success = true,
                        Errors = results.Errors,
                        Warnings = results.Warnings,
                        Status = string.Format(
                            "Validated {0} property elements in {1}ms",
                            results.PropertyList.Items.Count(),
                            stopWatch.ElapsedMilliseconds)
                    });
                }
                catch (Exception ex)
                {
                    return Json(new
                    {
                        Success = false,
                        Status = string.Format(@"Unable to process XML, exception: {0} {1}", ex.Message, ex.InnerException != null ? ex.InnerException.Message : null),
                        Errors = new string[] { },
                        Warnings = new string[] { }
                    });
                }

            }

        }
    }
}