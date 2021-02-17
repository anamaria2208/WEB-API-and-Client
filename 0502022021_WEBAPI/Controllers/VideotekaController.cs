using _0502022021_WEBAPI.Models;
using _0502022021_WEBAPI.Models.Dto;
using _0502022021_WEBAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _0502022021_WEBAPI.Controllers
{
    public class VideotekaController : ApiController
    {
        private VideotekaService service;
        public VideotekaController()
        {
            service = new VideotekaService();
        }


        [Route("filmovi")]
        [HttpGet]
        public HttpResponseMessage DohvatiFilmove()
        {
            return Request.CreateResponse(HttpStatusCode.OK, service.DohvatiFilmove(), Configuration.Formatters.JsonFormatter);
        }

        [Route("filmovi")]
        [HttpPost]
        public HttpResponseMessage KreirajFilm(FilmDto film)
        {
            service.KreirajFilm(film);
            return Request.CreateResponse(HttpStatusCode.Created, new ResponseMsg(HttpStatusCode.Created), Configuration.Formatters.JsonFormatter);
        }

        [Route("filmovi/{id}")]
        [HttpDelete]
        public HttpResponseMessage ObrisiFilm(int id)
        {
            service.IzbrisiFilm(id);
            return Request.CreateResponse(HttpStatusCode.Accepted, new ResponseMsg(HttpStatusCode.Accepted), Configuration.Formatters.JsonFormatter);
        }


        [Route("filmovi/{id}")]
        [HttpPut]
        public HttpResponseMessage UpdateFilm(Film film)
        {
            service.UpdateFilm(film);
            return Request.CreateResponse(HttpStatusCode.OK, new ResponseMsg(HttpStatusCode.OK), Configuration.Formatters.JsonFormatter);
        }
    }
}
