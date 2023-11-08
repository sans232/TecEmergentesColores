using System;

namespace CapaEntidad
{
    public class ResultadoNuevo
    {
        public int id { get; set; }
        public int colorfondoid { get; set; }
        public int colortextoid { get; set; }
        public int colorcuadroid { get; set; }
        public DateTime hora { get; set; }
        public int mensajeid { get; set; }
        public string direcip { get; set; }
        public string ubicacionip { get; set; }
        public string dispositivo { get; set; }
        public string evaluacion { get; set; }
        public bool respuesta { get; set; }

    }
}
