using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Colorfondo
    {
        public List<Colorfondo> Listar()
        {
            List<Colorfondo> lista = new List<Colorfondo>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    string query = "SELECT id, color FROM Colorfondo";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Colorfondo()
                            {
                                id = Convert.ToInt32(dr["id"]),
                                color = dr["color"].ToString()
                            });
                        }
                    }
                }
            }
            catch
            {
                lista = new List<Colorfondo>();

            }
            return lista;
        }
    }
}
