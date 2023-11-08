using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;


namespace CapaNegocio
{
    public class CN_Colorcuadro
    {
        private CD_Colorcuadro objCapaDato = new CD_Colorcuadro();

        public List<Colorcuadro> Listar()
        {
            return objCapaDato.Listar();
        }

    }
}
