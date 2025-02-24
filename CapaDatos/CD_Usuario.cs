using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))//Hago la conexion a la base de datos
            {
                try
                {
                    string query = "select ID_USUARIO,Documento,NombreCompleto,Correo," +
                        "Clave,Estado from USUARIO";

                    SqlCommand cmd = new SqlCommand(query,oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                ID_USUARIO = Convert.ToInt32(dr["ID_USUARIO"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean( dr["Estado"])

                            });
                        }
                    }
                }
                catch(Exception ex)
                {
                    lista =new List<Usuario>();
                }
            }
            return lista;
        }
    }
}
