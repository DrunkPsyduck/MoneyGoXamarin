using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyGo.Models
{
    public class Transacciones
    {
      
        [JsonProperty("IDUSUARIO")]
        
        public int IdUsuario { get; set; }

        [JsonProperty("NOMBRE")]
        public String Nombre { get; set; }

        [JsonProperty("NombreUsuario")]
        public String NombreUsuario { get; set; }

        [JsonProperty("Email")]
        public String Email { get; set; }

        [JsonProperty("ImagenUsuario")]
        public String ImagenUsuario { get; set; }

        [JsonProperty("PASSWORD")]
        public byte[] Password { get; set; }

        [JsonProperty("SALT")]
        public String Salt { get; set; }
    }
}
