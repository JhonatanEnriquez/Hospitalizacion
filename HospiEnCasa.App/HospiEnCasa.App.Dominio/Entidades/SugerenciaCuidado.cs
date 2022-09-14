using System;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{
    public class SugerenciaCuidado
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Descripcion { get; set; }
    }
}