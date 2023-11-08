using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;


namespace CapaNegocio
{
    public class CN_Combocolores
    {
        private CD_Combocolores objCapaDato = new CD_Combocolores();

        public List<Combocolores> Listar()
        {
            return objCapaDato.Listar();
        }

    }
}
