using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05022021_CLIENT.Models
{
    public class FilmDto
    {

        public string Naziv { get; set; }
        public int Godina { get; set; }
        public string Zanr { get; set; }
    }

    public class FilmDtoResponse
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public string Zanr { get; set; }
    }
}