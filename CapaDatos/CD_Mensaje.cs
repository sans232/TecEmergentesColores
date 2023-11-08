using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Mensaje
    {
        public List<Mensaje> Listar()
        {
            List<Mensaje> lista = new List<Mensaje>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    string query = "SELECT id, moraleja, valor FROM Mensajes";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Mensaje()
                            {
                                id = Convert.ToInt32(dr["id"]),
                                moraleja = dr["moraleja"].ToString(),
                                valor = dr["valor"].ToString()
                            });
                        }
                    }
                }
            }
            catch
            {
                lista = new List<Mensaje>();

            }
            return lista;
        }
    }
}
