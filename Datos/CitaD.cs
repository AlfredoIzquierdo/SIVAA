﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CitaD
    {
        string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
        public void Insertar(Cita Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abrir la conexión y crear el Query
                Cnx.Open();
                string CdSql = "INSERT INTO Cita (IDCita,IDEmpleado,IDCliente,Dia,Mes,Año,Hora,EstadoCita) VALUES (@Ci,@Em,@C,@D,@M,@A,@H,'Activa')";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))//SolicitA: la cadena de SQL y la conexeión
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Ci", Pqte.IDCita);//Get y set de la capa entidad
                    Cmd.Parameters.AddWithValue("@Em", Pqte.IDEmpleado);
                    Cmd.Parameters.AddWithValue("@C", Pqte.IDCliente);
                    Cmd.Parameters.AddWithValue("@D", Pqte.Dia);
                    Cmd.Parameters.AddWithValue("@M", Pqte.Mes);
                    Cmd.Parameters.AddWithValue("@A", Pqte.Año);
                    Cmd.Parameters.AddWithValue("@H", Pqte.Hora);
                    Cmd.ExecuteNonQuery();
                    //Borrar variable cmd de la memoria
                    Cmd.Dispose();
                }
                //Cierre
                Cnx.Close();
            }
        }

        public List<Cita> ListadoTotal()
        {
            List<Cita> productos = new List<Cita>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select * from Cita";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Cita Pqte = new Cita
                        {
                            IDCita = Convert.ToString(Dr["IDCita"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            EstadoCita = Convert.ToString(Dr["EstadoCita"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<CitaNoUsar> MostrarCitas()
        {
            List<CitaNoUsar> productos = new List<CitaNoUsar>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select C.IDCita, C.Dia,C.Mes,C.Año,C.Hora,C.IDEmpleado,Cli.Nombre,Cli.ApellidoPaterno,Cli.ApellidoMaterno from Cita C inner join Cliente Cli on C.IDCliente = Cli.IDCliente where C.EstadoCita = 'Activa' or C.EstadoCita = 'Activo'";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        CitaNoUsar Pqte = new CitaNoUsar
                        {
                            IDCita = Convert.ToString(Dr["IDCita"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            ApellidoPaterno = Convert.ToString(Dr["ApellidoPaterno"]),
                            ApellidoMaterno = Convert.ToString(Dr["ApellidoMaterno"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public void EliminarDesaparecer(string CodPqt)
        {

            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "Update Cita Set EstadoCita='Inactivo' WHERE IDCita=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                Cnx.Close();
            }
        }
        public List<CitaNoUsar> MostrarFiltroCita(string opcion, string CodPqt)
        {
            List<CitaNoUsar> productos = new List<CitaNoUsar>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select C.IDCita, C.Dia,C.Mes,C.Año,C.Hora,C.IDEmpleado,Cli.Nombre,Cli.ApellidoPaterno,Cli.ApellidoMaterno from Cita C inner join Cliente Cli on C.IDCliente = Cli.IDCliente where (C.EstadoCita = 'Activa' or C.EstadoCita = 'Activo') and C." + opcion+"=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        CitaNoUsar Pqte = new CitaNoUsar
                        {
                            IDCita = Convert.ToString(Dr["IDCita"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            ApellidoPaterno = Convert.ToString(Dr["ApellidoPaterno"]),
                            ApellidoMaterno = Convert.ToString(Dr["ApellidoMaterno"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<CitaNoUsar> FiltradoCliente(string opcion, string CodPqt)
        {
            List<CitaNoUsar> productos = new List<CitaNoUsar>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select C.IDCita, C.Dia,C.Mes,C.Año,C.Hora,C.IDEmpleado,Cli.Nombre,Cli.ApellidoPaterno,Cli.ApellidoMaterno from Cita C inner join Cliente Cli on C.IDCliente = Cli.IDCliente where (C.EstadoCita = 'Activa' or C.EstadoCita = 'Activo') and Cli." + opcion + "=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        CitaNoUsar Pqte = new CitaNoUsar
                        {
                            IDCita = Convert.ToString(Dr["IDCita"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            ApellidoPaterno = Convert.ToString(Dr["ApellidoPaterno"]),
                            ApellidoMaterno = Convert.ToString(Dr["ApellidoMaterno"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<CitaNoUsar> MostrarFecha(string dia,string mes, string año)
        {
            List<CitaNoUsar> productos = new List<CitaNoUsar>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select C.IDCita, C.Dia,C.Mes,C.Año,C.Hora,C.IDEmpleado,Cli.Nombre,Cli.ApellidoPaterno,Cli.ApellidoMaterno from Cita C inner join Cliente Cli on C.IDCliente = Cli.IDCliente where (C.EstadoCita = 'Activa' or C.EstadoCita = 'Activo') and C.Dia=@Cl and C.Mes=@m and C.Año = @a";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", dia);
                    Cmd.Parameters.AddWithValue("@m", mes);
                    Cmd.Parameters.AddWithValue("@a", año);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        CitaNoUsar Pqte = new CitaNoUsar
                        {
                            IDCita = Convert.ToString(Dr["IDCita"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            ApellidoPaterno = Convert.ToString(Dr["ApellidoPaterno"]),
                            ApellidoMaterno = Convert.ToString(Dr["ApellidoMaterno"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public Cita ObtenerPdto(string CodPqt)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM Cita WHERE IDCita=@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        Cita Pqte = new Cita
                        {
                            IDCita = Convert.ToString(Dr["IDCita"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            EstadoCita = Convert.ToString(Dr["EstadoCita"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }

        public void Eliminar(string CodPqt)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "DELETE FROM Cita WHERE IDCita=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                Cnx.Close();
            }
        }

        public void Actualizar(Cita Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "UPDATE Cita SET IDEmpleado=@Nm,IDCliente=@App, Dia=@Apm,Mes=@Rfc,Año=@Cr,Hora=@Tl WHERE IDCita=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Cl", Pqte.IDCita);//Get y set de la capa entidad
                    Cmd.Parameters.AddWithValue("@Nm", Pqte.IDEmpleado);
                    Cmd.Parameters.AddWithValue("@App", Pqte.IDCliente);
                    Cmd.Parameters.AddWithValue("@Apm", Pqte.Dia);
                    Cmd.Parameters.AddWithValue("@Rfc", Pqte.Mes);
                    Cmd.Parameters.AddWithValue("@Cr", Pqte.Año); 
                    Cmd.ExecuteNonQuery();
                    //Borrar variable cmd de la memoria
                    Cmd.Dispose();
                }
                Cnx.Close();
            }
        }
    }
}
