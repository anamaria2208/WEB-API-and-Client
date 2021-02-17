using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace _0502022021_WEBAPI.Models
{
    public class ResponseMsg
    {
        public string Msg { get; set; }
        public ResponseMsg()
        {
        }

        public ResponseMsg(HttpStatusCode input)
        {
            switch (input)
            {
               
                case HttpStatusCode.OK:
                    Msg = "OK";
                    break;
                case HttpStatusCode.Created:
                    Msg = "Kreirano";
                    break;
                case HttpStatusCode.Accepted:
                    Msg = "Prihvaćeno";
                    break;
                case HttpStatusCode.NoContent:
                    Msg = "Nema sadržaja";
                    break;
                case HttpStatusCode.NotFound:
                    Msg = "Nije pronađeno";
                    break;
                default:
                    Msg = input.ToString();
                    break;
            }
        }
    }
}