using _05022021_CLIENT.Models;
using _05022021_CLIENT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05022021_CLIENT.Controllers
{
    public class HomeController : Controller
    {
        VideotekaServices services;
        public HomeController()
        {
            services = new VideotekaServices();

        }
        public ActionResult Filmovi()
        {
            var filmovi = services.DohvatiFilmove();
            return View(filmovi);
        }


        public ActionResult KreirajFilm()
        {
            return View(new FilmDtoResponse());
        }

        [HttpPost]
        public ActionResult KreirajFilm(FilmDtoResponse film)
        {
            services.KreirajFilm(film);
            return RedirectToAction("Filmovi");
        }

        public ActionResult ObrisiFilm(int id)
        {
            services.ObrisiFilm(id);
            return RedirectToAction("Filmovi");
        }

        public ActionResult UpdateFilm(int id)
        {
            var film = services.DohvatiFilmove().FirstOrDefault(x => x.Id == id);
            return View(film);
        }

        [HttpPost]
        public ActionResult UpdateFilm(FilmDtoResponse film)
        {
            services.UpdateFilm(film);
            return RedirectToAction("Filmovi");
        }


        


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}