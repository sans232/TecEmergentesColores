using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;


namespace CapaNegocio
{
    public class CN_Colortexto
    {
        private CD_Colortexto objCapaDato = new CD_Colortexto();

        public List<Colortexto> Listar()
        {
            return objCapaDato.Listar();
        }

    }
}
