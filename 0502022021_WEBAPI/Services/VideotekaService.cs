using _0502022021_WEBAPI.Context;
using _0502022021_WEBAPI.Models;
using _0502022021_WEBAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0502022021_WEBAPI.Services
{
    public class VideotekaService
    {


        private ApplicationDbContext db;

        public VideotekaService()
        {
            db = new ApplicationDbContext();
        }

        public List<Film> DohvatiFilmove()
        {
            return db.Film.ToList();
        }

        public void IzbrisiFilm(int id)
        {
            var filmInDb = db.Film.FirstOrDefault(x => x.Id == id);
            if (filmInDb == null)
            {
                return;
            }
            db.Film.Remove(filmInDb);
            db.SaveChanges();
        }

        public void UpdateFilm(Film film)
        {
            var filmInDb = db.Film.FirstOrDefault(x => x.Id == film.Id);
            if (filmInDb == null)
            {
                return;
            }
            filmInDb.Naziv = film.Naziv;
            filmInDb.Godina = film.Godina;
            filmInDb.Zanr = film.Zanr;
            db.SaveChanges();
        }

        public void KreirajFilm(FilmDto film)
        {
            db.Film.Add(new Film(film));
            db.SaveChanges();
        }



    }
}