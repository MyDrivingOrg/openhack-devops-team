using System;
using Newtonsoft.Json;
using System.Reflection;

namespace poi.Models
{
    public class Healthcheck
    {
        public Healthcheck()
        {
            Message = "POI Service Healthcheck";
            Status = "Healthy";
            Version = "version 3";//Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get;set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        [Newtonsoft.Json.JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}
