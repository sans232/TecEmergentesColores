using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Mensaje
    {
        private CD_Mensaje objCapaDato = new CD_Mensaje();

        public List<Mensaje> Listar()
        {
            return objCapaDato.Listar();
        }

    }
}
