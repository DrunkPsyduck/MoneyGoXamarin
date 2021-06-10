using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyGo.Models
{
    public class Usuario
    {

        [JsonProperty("IDTRANSACCION")]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTransaccion { get; set; }

        [JsonProperty("IDUSUARIO")]
        public int IdUsuario { get; set; }


        [JsonProperty("CANTIDAD")]
        public Double Cantidad { get; set; }

        [JsonProperty("TIPOTRANSACCION")]
        public String TipoTransaccion { get; set; }

        [JsonProperty("FECHATRANSACCION")]
        public DateTime FechaTransaccion { get; set; }

        [JsonProperty("CONCEPTO")]
        public String Concepto { get; set; }
    }
}
