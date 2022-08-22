using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NDatos
    {
        public static string insertardatoestudiante(string nombre, string apellido, string carrera, string correo, string edificio, string aula, DateTime horaentrada, DateTime horasalida, string motivovisita, byte[] foto, string lugardirirse)
        {
            Datos objeto = new Datos();
            objeto.Nombre = nombre;
            objeto.Apellido = apellido;
            objeto.Carrera = carrera;
            objeto.Correo = correo;
            objeto.Edificio = edificio;
            objeto.Aula = aula;
            objeto.HoraEstranda = horaentrada;
            objeto.HoraSalida = horasalida;
            objeto.MotivoVisita = motivovisita;
            objeto.FotoVisitante = foto;
            objeto.LugarDirigirse = lugardirirse;

            return objeto.insertardatoestudiante(objeto);

        }
        public static string insertardatousuario(string nombre, string apellido, DateTime fechanacimiento,
            string usuario, string contrasena, string tipousuario
            )
        {
            Datos objeto = new Datos();
            objeto.NombreU = nombre;
            objeto.ApellidoU = apellido;
            objeto.Fechanacimiento = fechanacimiento;
            objeto.Usuario = usuario;
            objeto.Contrasena = contrasena;
            objeto.Tipousuario = tipousuario;

            return objeto.insertardatousuario(objeto);
        }

        public static string insertardatoedificios(string edificios, string aulas
            )
        {
            Datos objeto = new Datos();
            objeto.Edificioe = edificios;
            objeto.Aula = aulas;
            

            return objeto.insertardatoedificios(objeto);
        }

        public static DataTable mostrardatocomboedificio()
        {
            Datos objeto = new Datos();
            return objeto.mostrardatocomboedificio(objeto);
        }

        public static DataTable mostrardatocomboaula()
        {
            Datos objeto = new Datos();
            return objeto.mostrardatocomboaula(objeto);
        }

        public static string iniciarsesion(string usuarioi, string contrasenai)
        {
            Datos objeto = new Datos();
            objeto.Usuarioi = usuarioi;
            objeto.Contrasenai = contrasenai;
            return objeto.iniciarsesion(objeto);
            
        }

        public static DataTable buscaredificio(string edificioc)
        {
            Datos objeto = new Datos();
            objeto.Edificioc = edificioc;
            return objeto.buscaredificio(objeto);
        }

        public static DataTable mostrardato()
        {
            Datos objeto = new Datos();
            return objeto.mostrardato(objeto);
        }

        public static DataTable mostraredificio(string edificioc)
        {
            Datos objeto = new Datos();
            objeto.Edificioc = edificioc;
            return objeto.buscaredificio(objeto);
        }

        public static Bitmap mostarimagen(int id)
        {
            Datos objeto = new Datos();
            objeto.Id = id;
            return objeto.cargarimagen(objeto);
        }

    }
}
