using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EN;

namespace DAL
{
    public class ContactoDAL
    {
        public string mensaje = "";
        public IDbConnection conn = DBConn.conexion();
        public SqlCommand cmd = new SqlCommand();
        public string proy1 = "";

        public string VCONTUsuario(int id, string campo)
        {

            try
            {
                string dato = "";

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "VCONTUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = id;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                var rset = cmd.ExecuteReader();

                while (rset.Read())
                {
                    dato = rset[campo].ToString();
                }

                conn.Close();

                return dato;

            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = "Error SQL al Llenar el dato del Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "Error al Llenar el dato del Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;

            }


        }
        public String SpCONTUsuarioAdd(string nombre, string email, string contrasena)
        {
            string dato = "";
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCONTUsuarioAdd";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Nickname", SqlDbType.VarChar, 100).Value = nombre;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = email;
                cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar, 20).Value = contrasena;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                var rset = cmd.ExecuteReader();

                while (rset.Read())
                {
                    dato = rset["Id"].ToString();
                }
                conn.Close();

                return dato;


            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = "Error SQL al Agregar el Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "Error al Agregar el Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;

            }

        }
        public string SpCONTUsuarioDel(int id)
        {

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCONTUsuarioDel";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = id;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                int resultado = cmd.ExecuteNonQuery();

                conn.Close();

                return "Correcto";


            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = "Error SQL al Borrar el Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "Error al Borrar el Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;

            }


        }
        public string SpCONTUsuarioUP(int id, string nombre, string email, string contrasena, bool Estatus)
        {

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCONTUsuarioUP";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@Nickname", SqlDbType.VarChar, 100).Value = nombre;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = email;
                cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar, 20).Value = contrasena;
                cmd.Parameters.Add("@Estatus", SqlDbType.Bit).Value = Estatus;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                int resultado = cmd.ExecuteNonQuery();

                conn.Close();

                return "Correcto";


            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = "Error SQL al Modificar el Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "'Error al Modificar el Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;

            }


        }

        public List<ContactoEN> VCONTUsuarioDet(int id)
        {

            try
            {
                var lista = new List<ContactoEN>();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "VCONTUsuarioDet";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@IdUsuario", SqlDbType.VarChar, 100).Value = id;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                var rset = cmd.ExecuteReader();

                while (rset.Read())
                {
                    var contacto = new ContactoEN();
                    contacto.IdContacto = Convert.ToInt32(rset["IdContacto"]);
                    contacto.NumeroTelefono = rset["NumeroTelefono"].ToString();

                    lista.Add(contacto);
                }

                conn.Close();

                return lista;

            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = "Error SQL al Llenar la lista de Contacto: " + ex.Message.ToString().Replace("'", "-") + ".";
                return null;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "Error al Llenar la lista de Contacto: " + ex.Message.ToString().Replace("'", "-") + ".";
                return null;

            }


        }
        public String SpCONTContactoAdd(string numero, int idusuario)
        {
            string dato = "";
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCONTContactoAdd";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@NumeroTelefono", SqlDbType.VarChar, 10).Value = numero;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idusuario;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                var rset = cmd.ExecuteReader();

                while (rset.Read())
                {
                    dato = rset["Id"].ToString();
                }
                conn.Close();

                return dato;


            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = "Error SQL al Agregar el Contacto: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "Error al Agregar el Contacto: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;

            }

        }

        public string SpCONTContactoDel(int id)
        {

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCONTContactoDel";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@IdContacto", SqlDbType.Int).Value = id;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                int resultado = cmd.ExecuteNonQuery();

                conn.Close();

                return resultado.ToString();


            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = "alert('Error SQL al Borrar el Contacto: " + ex.Message.ToString().Replace("'", "-") + ".');";
                return mensaje;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "alert('Error al Borrar el Contacto: " + ex.Message.ToString().Replace("'", "-") + ".');";
                return mensaje;

            }


        }
        public string SpCONTContactoUP(int id, string numero)
        {
            string dato = "";

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCONTContactoUP";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@IdContacto", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@NumeroTelefono", SqlDbType.VarChar, 100).Value = numero;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                var rset = cmd.ExecuteReader();

                while (rset.Read())
                {
                    dato = rset["Usuario"].ToString();
                }
                conn.Close();

                return dato;


            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = "Error SQL al Modificar el Contacto: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "Error al Modificar el Contacto: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;

            }


        }
        public string SpCONTUsuarioValida(string email, string contrasena)
        {
            string dato = "";

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SpCONTUsuarioValida";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = email;
                cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar, 20).Value = contrasena;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                var rset = cmd.ExecuteReader();

                while (rset.Read())
                {
                    dato = rset["IdUsuario"].ToString();
                }
                conn.Close();

                return dato;

            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = "Error SQL al Validar el Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = "Error al Validar el Usuario: " + ex.Message.ToString().Replace("'", "-") + ".";
                return mensaje;

            }


        }
        public List<UsuarioEN> VCONTUsuario1(int id)
        {

            try
            {
                var lista = new List<UsuarioEN>();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "VCONTUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = id;
                cmd.Connection = conn as SqlConnection;
                conn.Open();
                var rset = cmd.ExecuteReader();

                while (rset.Read())
                {
                    var usuario = new UsuarioEN();
                    usuario.IdUsuario = Convert.ToInt32(rset["IdUsuario"]);
                    usuario.Nombre = rset["Nickname"].ToString();
                    usuario.FechaRegistro = Convert.ToDateTime(rset["FechaRegistro"].ToString());
                    usuario.Email = rset["Email"].ToString();
                    usuario.Contrasena = rset["Contrasena"].ToString();
                    usuario.Estatus = Convert.ToBoolean(rset["Estatus"].ToString());

                    lista.Add(usuario);
                }

                conn.Close();

                return lista;

            }
            catch (SqlException ex)
            {
                conn.Close();
                mensaje = ex.Message;
                return null;
            }
            catch (Exception ex)
            {
                conn.Close();
                mensaje = ex.Message;
                return null;

            }


        }

    }
}
