using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Combocolores
    {
        public List<Combocolores> Listar()
        {
            List<Combocolores> lista = new List<Combocolores>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    string query = "SELECT id, colorfondo, colortexto FROM Combocolores";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Combocolores()
                            {
                                id = Convert.ToInt32(dr["id"]),
                                colorfondo = dr["colorfondo"].ToString(),
                                colortexto = dr["colortexto"].ToString()
                            });
                        }
                    }
                }
            }
            catch
            {
                lista = new List<Combocolores>();

            }
            return lista;
        }
    }
}
