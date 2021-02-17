using _05022021_CLIENT.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace _05022021_CLIENT.Services
{
    public class VideotekaServices
    {
        private static string url = "https://localhost:44356";
        private RestClient restClient;

        public VideotekaServices()
        {
            restClient = new RestClient(url);
        }


        public List<FilmDtoResponse> DohvatiFilmove()
        {
            RestRequest restRequest = new RestRequest("/filmovi")
            {
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };

            var response = restClient.Execute(restRequest);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("Ne mogu do servisa!");
            }

            return JsonConvert.DeserializeObject<List<FilmDtoResponse>>(response.Content);


        }

        public ResponseMsg KreirajFilm(FilmDtoResponse film)
        {
            RestRequest restRequest = new RestRequest("/filmovi")
            {
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            restRequest.AddJsonBody(film);

            var response = restClient.Execute(restRequest);

            if(response.StatusCode != HttpStatusCode.Created)
            {
                throw new Exception("Ne mogu do servisa");
            }

            return JsonConvert.DeserializeObject<ResponseMsg>(response.Content);

            
        }

        public ResponseMsg ObrisiFilm(int id)
        {
            RestRequest restRequest = new RestRequest("/filmovi/"+ id)
            {
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            //restRequest.AddJsonBody(id);

            var response = restClient.Execute(restRequest);

            if (response.StatusCode != HttpStatusCode.Accepted)
            {
                throw new Exception("Ne mogu do servisa");
            }

            return JsonConvert.DeserializeObject<ResponseMsg>(response.Content);


        }

        public ResponseMsg UpdateFilm(FilmDtoResponse film)
        {
            RestRequest restRequest = new RestRequest("/filmovi/"+ film.Id)
            {
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            restRequest.AddJsonBody(film);

            var response = restClient.Execute(restRequest);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("Ne mogu do servisa");
            }

            return JsonConvert.DeserializeObject<ResponseMsg>(response.Content);


        }
    }
}