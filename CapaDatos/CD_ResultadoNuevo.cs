using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_ResultadoNuevo
    {



        public int Registrar(ResultadoNuevo obj, out string Mensaje)
        {
            int idautogenerado = 0;

            Mensaje = string.Empty;
            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarResultado", oconexion);
                    cmd.Parameters.AddWithValue("colorfondoid", obj.colorfondoid);
                    cmd.Parameters.AddWithValue("colortextoid", obj.colortextoid);
                    cmd.Parameters.AddWithValue("colorcuadroid", obj.colorcuadroid);
                    cmd.Parameters.AddWithValue("hora", obj.hora);
                    cmd.Parameters.AddWithValue("mensajeid", obj.mensajeid);
                    cmd.Parameters.AddWithValue("direcip", obj.direcip);
                    cmd.Parameters.AddWithValue("ubicacionip", obj.ubicacionip);
                    cmd.Parameters.AddWithValue("dispositivo", obj.dispositivo);
                    cmd.Parameters.AddWithValue("evaluacion", obj.evaluacion);
                    cmd.Parameters.AddWithValue("respuesta", obj.respuesta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idautogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idautogenerado = 0;
                Mensaje = ex.Message;
            }
            return idautogenerado;
        }





    }
}
