using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;


namespace CapaNegocio
{
    public class CN_Colorfondo
    {
        private CD_Colorfondo objCapaDato = new CD_Colorfondo();

        public List<Colorfondo> Listar()
        {
            return objCapaDato.Listar();
        }

    }
}
