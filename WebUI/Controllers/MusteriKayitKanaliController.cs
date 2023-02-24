using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class MusteriKayitKanaliController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<MusteriKayitKanaliResponseDto> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44372/api/");
                //HTTP GET
                var responseTask = client.GetAsync("MusteriKayitKanali/GetMusteriKayitKanaliResponseDto ");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<MusteriKayitKanaliResponseDto>>();
                    readTask.Wait();

                    students = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    students = Enumerable.Empty<MusteriKayitKanaliResponseDto>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(students);
        }

       
    }
}
