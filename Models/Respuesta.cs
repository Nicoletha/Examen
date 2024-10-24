using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenPractico__U2.Models
{
    public class Respuesta
    {
        [JsonProperty("message")]
        public string ImageUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}