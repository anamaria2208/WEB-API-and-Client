using _0502022021_WEBAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0502022021_WEBAPI.Models
{
    public class Film: FilmBase
    {

        public Film()
        {
        }

        public Film(FilmDto model)
        {
            this.Naziv = model.Naziv;
            this.Godina = model.Godina;
            this.Zanr = model.Zanr;
        }


        public int Id { get; set; }
    }
}