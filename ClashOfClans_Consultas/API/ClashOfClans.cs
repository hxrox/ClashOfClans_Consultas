using ClashOfClans_Consultas.Modelos;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans_Consultas.API
{
    class ClashOfClans
    {
        private string _apiKey = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6ImIwOGRlNzViLTA5NzYtNDY1Ni04NzZjLTNlNTBhZjVhNjRjMCIsImlhdCI6MTQ1OTM4MTc1Niwic3ViIjoiZGV2ZWxvcGVyLzI1Mzk0NTY4LTg3ZTctNGM0ZS01MjA0LTAzMGVjYTJlOTA3YyIsInNjb3BlcyI6WyJjbGFzaCJdLCJsaW1pdHMiOlt7InRpZXIiOiJkZXZlbG9wZXIvc2lsdmVyIiwidHlwZSI6InRocm90dGxpbmcifSx7ImNpZHJzIjpbIjIwMS4xNDguODEuMiJdLCJ0eXBlIjoiY2xpZW50In1dfQ.YRp3TY7GSdjeKf3tYfAgLPeQQOZGBqRtHbgtX4IPqzrRg-df9Ki-G5L4p_pCpIbO-GToGCnGvnIrotoohlcTXA";
        private string _apiUrl = "https://api.clashofclans.com/";
        private string _apiVersion = "v1/";

        public Clan buscarClanPorTag(string tag)
        {
            return JsonConvert.DeserializeObject<Clan>(enviarSolicitud(_apiUrl + _apiVersion + "clans/" + System.Uri.EscapeDataString(tag)).Content);
        }
        public Clanes buscarClanPorNombre(string nombre)
        {
            return JsonConvert.DeserializeObject<Clanes>(enviarSolicitud(_apiUrl + _apiVersion + "clans?name=" + System.Uri.EscapeDataString(nombre)).Content);
        }
        public MiembrosClan consultarMiembrosClan(string tag)
        {
            return JsonConvert.DeserializeObject<MiembrosClan>(enviarSolicitud(_apiUrl + _apiVersion + "clans/" + System.Uri.EscapeDataString(tag) + "/members").Content);
        }
        public Clanes buscarClan(NameValueCollection parametros)
        {
            return JsonConvert.DeserializeObject<Clanes>(enviarSolicitud(_apiUrl + _apiVersion + "clans" + this.ToQueryString(parametros)).Content);
        }
        public Localidades consultarLocalidades()
        {
            return JsonConvert.DeserializeObject<Localidades>(enviarSolicitud(_apiUrl + _apiVersion + "locations").Content);
        }
        public Localidad consultarLocalidadPorId(int localidadId)
        {
            return JsonConvert.DeserializeObject<Localidad>(enviarSolicitud(_apiUrl + _apiVersion + "locations/" + localidadId).Content);
        }
        protected IRestResponse enviarSolicitud(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                request.AddHeader("authorization", "Bearer " + _apiKey);
                return client.Execute(request);
            }
            catch (Exception ex)
            {
                throw new System.InvalidOperationException("Error al enviar la solicitud.", ex);
            }
        }
        private string ToQueryString(NameValueCollection parametros)
        {
            var array = (from key in parametros.AllKeys
                         from value in parametros.GetValues(key)
                         select string.Format("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(value)))
                .ToArray();
            return "?" + string.Join("&", array);
        }
    }
}
