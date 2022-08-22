using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CapaDatos
{
    public class Datos
    {

        Conexion cn = new Conexion();

        private int _id;

        public int Id { get=> _id; set => _id = value; }

        private string _edificioc;

        public string Edificioc { get=> _edificioc; set => _edificioc = value; }

        private string _usuarioi;
        private string _contrasenai;

        public string Usuarioi { get => _usuarioi; set => _usuarioi = value;  }
        public string Contrasenai { get => _contrasenai; set => _contrasenai = value; }

        private int _idedificio;
        private string _edificioe;
        private string _aula;

        public int Idedificios { get => _idedificio; set => _idedificio = value; }
        public string Edificioe { get => _edificioe; set => _edificioe = value; }
        public string Aula { get => _aula; set => _aula = value; }

        private int _idusuario;
        private string _nombreu;
        private string _apellidou;
        private DateTime _fechanacimiento;
        private string _usuario;
        private string _contrasena;
        private string _tipousuario;

        public int Idusuario { get => _idusuario; set => _idusuario = value; }
        public string NombreU { get => _nombreu; set => _nombreu = value; }
        public string ApellidoU { get => _apellidou; set => _apellidou = value; }
        public DateTime Fechanacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
        public string Usuario { get => _usuario; set => _usuario = value;}
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public string Tipousuario { get => _tipousuario; set => _tipousuario = value; }



        private int _idestudiante;
        private string _nombre;
        private string _apellido;
        private string _carrera;
        private string _correo;
        private string _edificio;
        private string _aulae;
        private DateTime _horaentrada;
        private DateTime _horasalida;
        private string _motivovisita;
        private byte[] _fotovisitante;
        private string _lugardirigirse;

        public int Idestudiante { get => _idestudiante; set => _idestudiante = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public string Carrera { get => _carrera; set => _carrera = value; }

        public string Correo { get => _correo; set => _correo = value; }
        public string Edificio { get => _edificio; set => _edificio = value; }
        public string Aulae { get => _aulae; set => _aulae = value; }
        public DateTime HoraEstranda { get => _horaentrada; set => _horaentrada = value; }
        public DateTime HoraSalida { get => _horasalida; set => _horasalida = value; }
        public string MotivoVisita { get => _motivovisita; set => _motivovisita = value; }
        public byte[] FotoVisitante { get => _fotovisitante; set => _fotovisitante = value; }
        public string LugarDirigirse { get => _lugardirigirse; set => _lugardirigirse = value; }

        public Datos(int idestudiante, string nombre, string apellido, string carrera, 
            string correo, string edificio, string aulae ,DateTime horaentrada, DateTime horasalida, 
            string motivovisita, byte[] fotovisitante, string lugardirigirse, int idusuario, 
            string nombreu, string apellidou, DateTime fechanacimiento, string usuario, 
            string contrasena, string tipousuario, int idedificios, string edificioe, string aula, string usuarioi,string contrasenai, string edificioc, int id)
        {
            Idestudiante = idestudiante;
            Nombre = nombre;
            Apellido = apellido;
            Carrera = carrera;
            Correo = correo;
            Edificio = edificio;
            Aulae = aulae;
            HoraSalida = horasalida;
            MotivoVisita = motivovisita;
            FotoVisitante = fotovisitante;
            LugarDirigirse = lugardirigirse;

            Idusuario = idusuario;
            NombreU = nombreu;
            ApellidoU = apellidou;
            Fechanacimiento = fechanacimiento;
            Usuario = usuario;
            Contrasena = contrasena;
            Tipousuario = tipousuario;

            Idedificios = idedificios;
            Edificioe = edificioe;
            Aula = aula;

            Usuarioi = usuarioi;
            Contrasenai = contrasenai;

            Edificioc = edificioc;

            Id = id;

        }

        public Datos()
        {
        }

        public string insertardatoestudiante(Datos dato)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_estudiantes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idestudiante";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 30;
                ParNombre.Value = dato.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 30;
                ParApellido.Value = dato.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParCarrera = new SqlParameter();
                ParCarrera.ParameterName = "@Carrera";
                ParCarrera.SqlDbType = SqlDbType.VarChar;
                ParCarrera.Size = 20;
                ParCarrera.Value = dato.Carrera;
                SqlCmd.Parameters.Add(ParCarrera);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 20;
                ParCorreo.Value = dato.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParEdificio = new SqlParameter();
                ParEdificio.ParameterName = "@Edificio";
                ParEdificio.SqlDbType = SqlDbType.VarChar;
                ParEdificio.Size = 20;
                ParEdificio.Value = dato.Edificio;
                SqlCmd.Parameters.Add(ParEdificio);

                SqlParameter ParAula = new SqlParameter();
                ParAula.ParameterName = "@Aula";
                ParAula.SqlDbType = SqlDbType.VarChar;
                ParAula.Size = 20;
                ParAula.Value = dato.Aula;
                SqlCmd.Parameters.Add(ParAula);

                SqlParameter ParHoraEntrada = new SqlParameter();
                ParHoraEntrada.ParameterName = "@Hora_Entrada";
                ParHoraEntrada.SqlDbType = SqlDbType.DateTime;
                ParHoraEntrada.Value = dato.HoraEstranda;
                SqlCmd.Parameters.Add(ParHoraEntrada);

                SqlParameter ParHoraSalida = new SqlParameter();
                ParHoraSalida.ParameterName = "@Hora_Salida";
                ParHoraSalida.SqlDbType = SqlDbType.DateTime;
                ParHoraSalida.Value = dato.HoraSalida;
                SqlCmd.Parameters.Add(ParHoraSalida);

                SqlParameter ParMotivoVisita = new SqlParameter();
                ParMotivoVisita.ParameterName = "@Motivo_Visita";
                ParMotivoVisita.SqlDbType = SqlDbType.VarChar;
                ParMotivoVisita.Size = 100;
                ParMotivoVisita.Value = dato.MotivoVisita;
                SqlCmd.Parameters.Add(ParMotivoVisita);

                SqlParameter ParFotoVisitante = new SqlParameter();
                ParFotoVisitante.ParameterName = "@Foto_Visitante";
                ParFotoVisitante.SqlDbType = SqlDbType.Image;
                ParFotoVisitante.Value = dato.FotoVisitante;
                SqlCmd.Parameters.Add(ParFotoVisitante);

                SqlParameter ParLugarDirigirse = new SqlParameter();
                ParLugarDirigirse.ParameterName = "@Lugar_a_Dirigirse";
                ParLugarDirigirse.SqlDbType = SqlDbType.VarChar;
                ParLugarDirigirse.Size = 100;
                ParLugarDirigirse.Value = dato.LugarDirigirse;
                SqlCmd.Parameters.Add(ParLugarDirigirse);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso el registro";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;

        }

        public string insertardatousuario(Datos dato)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@Idusuario";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNombreU = new SqlParameter();
                ParNombreU.ParameterName = "@NombreU";
                ParNombreU.SqlDbType = SqlDbType.VarChar;
                ParNombreU.Size = 20;
                ParNombreU.Value = dato.NombreU;
                SqlCmd.Parameters.Add(ParNombreU);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@ApellidoU";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 20;
                ParApellido.Value = dato.ApellidoU;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParFechaNacimiento = new SqlParameter();
                ParFechaNacimiento.ParameterName = "@Fecha_Nacimiento";
                ParFechaNacimiento.SqlDbType = SqlDbType.DateTime;
                ParFechaNacimiento.Value = dato.Fechanacimiento;
                SqlCmd.Parameters.Add(ParFechaNacimiento);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@Usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = dato.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParContrasena = new SqlParameter();
                ParContrasena.ParameterName = "@Contrasena";
                ParContrasena.SqlDbType = SqlDbType.VarChar;
                ParContrasena.Size = 50;
                ParContrasena.Value = dato.Contrasena;
                SqlCmd.Parameters.Add(ParContrasena);

                SqlParameter ParTipoUsuario = new SqlParameter();
                ParTipoUsuario.ParameterName = "@Tipo_usuario";
                ParTipoUsuario.Size = 20;
                ParTipoUsuario.SqlDbType = SqlDbType.VarChar;
                ParTipoUsuario.Value = dato.Tipousuario;
                SqlCmd.Parameters.Add(ParTipoUsuario);

               
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso el registro";

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;

        }

        public string insertardatoedificios(Datos dato)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_edificios";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@Idedificio";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParEdificioe = new SqlParameter();
                ParEdificioe.ParameterName = "@Edificio";
                ParEdificioe.SqlDbType = SqlDbType.VarChar;
                ParEdificioe.Size = 20;
                ParEdificioe.Value = dato.Edificioe;
                SqlCmd.Parameters.Add(ParEdificioe);

                SqlParameter ParAula = new SqlParameter();
                ParAula.ParameterName = "@Aula";
                ParAula.SqlDbType = SqlDbType.VarChar;
                ParAula.Size = 20;
                ParAula.Value = dato.Aula;
                SqlCmd.Parameters.Add(ParAula);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se ingreso el registro";

                

                return rpta;
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;

        }

        public DataTable mostrardatocomboedificio(Datos dato)
        {
            DataTable dtresultado = new DataTable("dato");

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spcargar_edificio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtresultado;
        }

        public DataTable mostrardatocomboaula(Datos dato)
        {
            DataTable dtresultado = new DataTable("dato");

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spcargar_aula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtresultado;
        }

        public string iniciarsesion(Datos dato)
        {
            DataTable dt = new DataTable();
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_iniciar_sesion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@Usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = dato.Usuarioi;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParContrasena = new SqlParameter();
                ParContrasena.ParameterName = "@Contrasena";
                ParContrasena.SqlDbType = SqlDbType.VarChar;
                ParContrasena.Size = 20;
                ParContrasena.Value = dato.Contrasenai;
                SqlCmd.Parameters.Add(ParContrasena);

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dt);



                if (dt.Rows.Count == 1)
                {
                    if(dt.Rows[0][1].ToString() == "ADMIN")
                    {
                        rpta = "admin";
                    }
                    else if (dt.Rows[0][1].ToString() == "GENERAL")
                    {
                        rpta = "general";
                    }
                    
                }
                else
                {
                    rpta = "no";
                    
                }

                return rpta;

            }
            catch(Exception ex)
            {
                rpta = ex.Message;
               
            }
            finally {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return rpta;

        }

        public DataTable mostrardato(Datos dato)
        {
            DataTable dtresultado = new DataTable("dato");

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtresultado;

        }

        public DataTable buscaredificio(Datos dato)
        {
            DataTable dtresultado = new DataTable("dato");

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_consultar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Partextobuscar = new SqlParameter();
                Partextobuscar.ParameterName = "@Edificio";
                Partextobuscar.SqlDbType = SqlDbType.VarChar;
                Partextobuscar.Size = 100;
                Partextobuscar.Value = dato.Edificioc;
                SqlCmd.Parameters.Add(Partextobuscar);

                SqlDataAdapter sqladat = new SqlDataAdapter(SqlCmd);
                sqladat.Fill(dtresultado);



            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtresultado;

        }

        public Bitmap cargarimagen(Datos dato)
        {
            
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_imagen";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@Id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = dato.Id;
                SqlCmd.Parameters.Add(ParId);

                SqlDataReader reader = SqlCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["Foto_visitante"]);
                    Bitmap bm = new Bitmap(ms);
                    return bm;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

            }
            finally 
            { 
            
            }

            return null;
        }

    }
    }
