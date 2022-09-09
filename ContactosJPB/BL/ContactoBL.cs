using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EN;
using DAL;

namespace BL
{
    public class ContactoBL
    {
        ContactoDAL contactoDAL = new ContactoDAL();

        public string VCONTUsuario(int id, string campo)
        {
            return contactoDAL.VCONTUsuario(id, campo);
        }

        public String SpCONTUsuarioAdd(string nombre, string email, string contrasena)
        {
            return contactoDAL.SpCONTUsuarioAdd(nombre, email, contrasena);
        }
        public string SpCONTUsuarioDel(int id)
        {
            return contactoDAL.SpCONTContactoDel(id);
        }
        public string SpCONTUsuarioUP(int id, string nombre, string email, string contrasena, bool Estatus)
        {
            return contactoDAL.SpCONTUsuarioUP(id, nombre, email, contrasena, Estatus);
        }
        public List<ContactoEN> VCONTUsuarioDet(int id)
        {
            return contactoDAL.VCONTUsuarioDet(id);
        }
        public String SpCONTContactoAdd(string numero, int idusuario)
        {
            return contactoDAL.SpCONTContactoAdd(numero, idusuario);
        }
        public string SpCONTContactoDel(int id)
        {
            return contactoDAL.SpCONTContactoDel(id);
        }
        public string SpCONTContactoUP(int id, string numero)
        {
            return contactoDAL.SpCONTContactoUP(id, numero);
        }

        public string SpCONTUsuarioValida(string email, string contrasena)
        {
            return contactoDAL.SpCONTUsuarioValida(email, contrasena);
        }

    }
}
