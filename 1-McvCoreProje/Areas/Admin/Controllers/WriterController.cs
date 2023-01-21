using AMvcCoreProjeKampi.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AMvcCoreProjeKampi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }
        public IActionResult GetWriterByID(int writerid)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);

        }
        [HttpPost]
        public IActionResult AddWriters(WriterClass w)
        {
            writers.Add(w);
            var jasonwriters = JsonConvert.SerializeObject(w);
            return Json(jasonwriters);
        }

        public IActionResult DeleteWriters(int id)
        {
            var writerval = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writerval);
            return Json(writerval);
        }
        public IActionResult UpdateWriters(WriterClass w)
        {
            var writerss = writers.FirstOrDefault(x => x.Id == w.Id);
            writerss.Name = w.Name;
            var jsonwrier = JsonConvert.SerializeObject(w);
            return Json(jsonwrier);
        }




        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id=1,
                Name="Ayşe"

            },
            new WriterClass
            {
                Id=2,
                Name="Fatma"

            },
            new WriterClass
            {
                Id=3,
                Name="Hayriye"

            }
        };
    }
}
