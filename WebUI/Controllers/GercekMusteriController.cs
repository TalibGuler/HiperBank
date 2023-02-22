using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web.Http;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class GercekMusteriController : Controller
    {
        // public IActionResult Index()
        //{
        //    return View();
        //}


        public ActionResult Index()
        {
            IEnumerable<GercekMusteriModels> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44372/api/");
                //HTTP GET
                var responseTask = client.GetAsync("GercekMusteri/getall");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<GercekMusteriModels>>();
                    readTask.Wait();

                    students = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    students = Enumerable.Empty<GercekMusteriModels>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(students);
        }


        public ActionResult Edit(int id)
        {
            //GercekMusteriModels student = null;

            using (var client = new HttpClient())
            {
            
                client.BaseAddress = new Uri("https://localhost:44372/api/GercekMusteri/update");
                //HTTP GET
                var responseTask = client.GetAsync("GercekMusteri?id=" + id.ToString());
                responseTask.Wait();

                var putTask = client.PutAsJsonAsync<GercekMusteri>("student", student);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }

                //var result = responseTask.Result;
                //if (result.IsSuccessStatusCode)
                //{
                //    var readTask = result.Content.ReadAsAsync<GercekMusteriModels>();
                //    readTask.Wait();

                //    student = readTask.Result;
                //}

            }

            return View(student);
        }


    }
}
