using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0502022021_WEBAPI.Models.Dto
{
    public class FilmDto : FilmBase
    {
    }

    public class FilmBase
    {
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public string Zanr { get; set; }
    }
}