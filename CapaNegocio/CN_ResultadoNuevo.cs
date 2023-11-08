using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_ResultadoNuevo
    {
        private CD_ResultadoNuevo objCapaDato = new CD_ResultadoNuevo();

        public int Registrar(ResultadoNuevo obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (string.IsNullOrEmpty(Mensaje))
            {

                return objCapaDato.Registrar(obj, out Mensaje);

            }
            else
            {

                return 0;
            }



        }
    }
}
