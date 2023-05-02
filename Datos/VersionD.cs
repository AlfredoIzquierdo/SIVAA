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
    public class VersionD
    {
        string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
        public void Insertar(Versions Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abrir la conexión y crear el Query
                Cnx.Open();
                string CdSql = "INSERT INTO Version (IDVersion,IDVehiculo,Llantas,TipoAsientos,CamaraTrasera,Pantalla,TipoCombustible,Version,Rines,Cilindraje,Costo,CapacidadCajuela,DistanciaEjes,Anchura,Altura,AudioVelC,TomaCorriente,TipoTraccion,NumPuertas,Transmision,FarosHal,NumEngranajes,ACAutom,FarosLED,RendimientoCombustible,FrenosTraseros,FrenosDelanteros,SuspensionDelantera,SuspensionTrasera,EspejosLatDirC,EspejosLatAE,EstadoVersion,Año) VALUES (@IV,@Ve,@L,@TA,@CT,@P,@TC,@V,@R,@Ci,@Co,@CC,@DE,@At,@Al,@AVC,@TCO,@TT,@NP,@Trans,@FH,@NumEng,@ACA,@FLED,@RCom,@FTr,@FDl,@SD,@ST,@ELDC,@ELAE,@EsV,@An)";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))//SolicitA: la cadena de SQL y la conexeión
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@IV", Pqte.IDVersion);//Get y set de la capa entidad
                    Cmd.Parameters.AddWithValue("@Ve", Pqte.IDVehiculo);
                    Cmd.Parameters.AddWithValue("@L", Pqte.Llantas);
                    Cmd.Parameters.AddWithValue("@TA", Pqte.TipoAsientos);
                    Cmd.Parameters.AddWithValue("@CT", Pqte.CamaraTrasera);
                    Cmd.Parameters.AddWithValue("@P", Pqte.Pantalla);
                    Cmd.Parameters.AddWithValue("@TC", Pqte.TipoCombustible);
                    Cmd.Parameters.AddWithValue("@V", Pqte.Version);
                    Cmd.Parameters.AddWithValue("@R", Pqte.Rines);
                    Cmd.Parameters.AddWithValue("@Ci", Pqte.Cilindraje);
                    Cmd.Parameters.AddWithValue("@Co", Pqte.Costo);
                    Cmd.Parameters.AddWithValue("@CC", Pqte.CapacidadCajuela);
                    Cmd.Parameters.AddWithValue("@DE", Pqte.DistanciaEjes);
                    Cmd.Parameters.AddWithValue("@At", Pqte.Anchura);
                    Cmd.Parameters.AddWithValue("@Al", Pqte.Altura);
                    Cmd.Parameters.AddWithValue("@AVC", Pqte.AudioVelC);
                    Cmd.Parameters.AddWithValue("@TCO", Pqte.TomaCorriente);
                    Cmd.Parameters.AddWithValue("@TT", Pqte.TipoTraccion);
                    Cmd.Parameters.AddWithValue("@NP", Pqte.NumPuertas);
                    Cmd.Parameters.AddWithValue("@Trans", Pqte.Transmision);
                    Cmd.Parameters.AddWithValue("@FH", Pqte.FarosHal);
                    Cmd.Parameters.AddWithValue("@NumEng", Pqte.NumEngranajes);
                    Cmd.Parameters.AddWithValue("@ACA", Pqte.ACAutom);
                    Cmd.Parameters.AddWithValue("@FLED", Pqte.FarosLED);
                    Cmd.Parameters.AddWithValue("@RCom", Pqte.RendimientoCombustible);
                    Cmd.Parameters.AddWithValue("@FTr", Pqte.FrenosTraseros);
                    Cmd.Parameters.AddWithValue("@FDl", Pqte.FrenosDelanteros);
                    Cmd.Parameters.AddWithValue("@SD", Pqte.SuspensionDelantera);
                    Cmd.Parameters.AddWithValue("@ST", Pqte.SuspensionTrasera);
                    Cmd.Parameters.AddWithValue("@ELDC", Pqte.EspejosLatDirC);
                    Cmd.Parameters.AddWithValue("@ELAE", Pqte.EspejosLatAE);
                    Cmd.Parameters.AddWithValue("@EsV", Pqte.EstadoVersion);
                    Cmd.Parameters.AddWithValue("@An", Pqte.Año);
                    Cmd.ExecuteNonQuery();

                    Cmd.Dispose();
                }
                //Cierre
                Cnx.Close();
            }
        }

       

        public Versions ObtenerPdto(string CodPqt)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM Version WHERE IDVersion=@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        Versions Pqte = new Versions
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            Llantas = Convert.ToString(Dr["Llantas"]),
                            TipoAsientos = Convert.ToString(Dr["TipoAsientos"]),
                            CamaraTrasera = Convert.ToString(Dr["CamaraTrasera"]),
                            Pantalla = Convert.ToString(Dr["Pantalla"]),
                            TipoCombustible = Convert.ToString(Dr["TipoCombustible"]),
                            Version = Convert.ToString(Dr["Version"]),
                            Rines = Convert.ToString(Dr["Rines"]),
                            Cilindraje = Convert.ToString(Dr["Cilindraje"]),
                            Costo = Convert.ToDouble(Dr["Costo"]),
                            CapacidadCajuela = Convert.ToString(Dr["CapacidadCajuela"]),
                            DistanciaEjes = Convert.ToString(Dr["DistanciaEjes"]),
                            Anchura = Convert.ToString(Dr["Anchura"]),
                            Altura = Convert.ToString(Dr["Altura"]),
                            AudioVelC = Convert.ToString(Dr["AudioVelC"]),
                            TomaCorriente = Convert.ToString(Dr["TomaCorriente"]),
                            TipoTraccion = Convert.ToString(Dr["TipoTraccion"]),
                            NumPuertas = Convert.ToString(Dr["NumPuertas"]),
                            Transmision = Convert.ToString(Dr["Transmision"]),
                            FarosHal = Convert.ToString(Dr["FarosHal"]),
                            NumEngranajes = Convert.ToString(Dr["NumEngranajes"]),
                            ACAutom = Convert.ToString(Dr["ACAutom"]),
                            FarosLED = Convert.ToString(Dr["FarosLED"]),
                            RendimientoCombustible = Convert.ToString(Dr["RendimientoCombustible"]),
                            FrenosTraseros = Convert.ToString(Dr["FrenosTraseros"]),
                            FrenosDelanteros = Convert.ToString(Dr["FrenosDelanteros"]),
                            SuspensionDelantera = Convert.ToString(Dr["SuspensionDelantera"]),
                            SuspensionTrasera = Convert.ToString(Dr["SuspensionTrasera"]),
                            EspejosLatDirC = Convert.ToString(Dr["EspejosLatDirC"]),
                            EspejosLatAE = Convert.ToString(Dr["EspejosLatAE"]),
                            EstadoVersion = Convert.ToString(Dr["EstadoVersion"]),
                            Año= Convert.ToString(Dr["Año"])


                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }
        public Versions ObtpqtPorDatos(string CodPqt, string ver, string mode)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "select Version.* from modelo, ModeloVersion,version, Vehiculo\r\nwhere modelo.IDModelo=ModeloVersion.IDModelo and ModeloVersion.IDVersion=Version.IDVersion\r\nand Version.IDVehiculo=Vehiculo.IDVehiculo and Vehiculo.Nombre=@Cl and Version.Version=@Ve\r\nand Modelo.Año=@Mo";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    Cmd.Parameters.AddWithValue("@Ve", ver);
                    Cmd.Parameters.AddWithValue("@Mo", mode);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        Versions Pqte = new Versions
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            Llantas = Convert.ToString(Dr["Llantas"]),
                            TipoAsientos = Convert.ToString(Dr["TipoAsientos"]),
                            CamaraTrasera = Convert.ToString(Dr["CamaraTrasera"]),
                            Pantalla = Convert.ToString(Dr["Pantalla"]),
                            TipoCombustible = Convert.ToString(Dr["TipoCombustible"]),
                            Version = Convert.ToString(Dr["Version"]),
                            Rines = Convert.ToString(Dr["Rines"]),
                            Cilindraje = Convert.ToString(Dr["Cilindraje"]),
                            Costo = Convert.ToDouble(Dr["Costo"]),
                            CapacidadCajuela = Convert.ToString(Dr["CapacidadCajuela"]),
                            DistanciaEjes = Convert.ToString(Dr["DistanciaEjes"]),
                            Anchura = Convert.ToString(Dr["Anchura"]),
                            Altura = Convert.ToString(Dr["Altura"]),
                            AudioVelC = Convert.ToString(Dr["AudioVelC"]),
                            TomaCorriente = Convert.ToString(Dr["TomaCorriente"]),
                            TipoTraccion = Convert.ToString(Dr["TipoTraccion"]),
                            NumPuertas = Convert.ToString(Dr["NumPuertas"]),
                            Transmision = Convert.ToString(Dr["Transmision"]),
                            FarosHal = Convert.ToString(Dr["FarosHal"]),
                            NumEngranajes = Convert.ToString(Dr["NumEngranajes"]),
                            ACAutom = Convert.ToString(Dr["ACAutom"]),
                            FarosLED = Convert.ToString(Dr["FarosLED"]),
                            RendimientoCombustible = Convert.ToString(Dr["RendimientoCombustible"]),
                            FrenosTraseros = Convert.ToString(Dr["FrenosTraseros"]),
                            FrenosDelanteros = Convert.ToString(Dr["FrenosDelanteros"]),
                            SuspensionDelantera = Convert.ToString(Dr["SuspensionDelantera"]),
                            SuspensionTrasera = Convert.ToString(Dr["SuspensionTrasera"]),
                            EspejosLatDirC = Convert.ToString(Dr["EspejosLatDirC"]),
                            EspejosLatAE = Convert.ToString(Dr["EspejosLatAE"]),
                            EstadoVersion = Convert.ToString(Dr["EstadoVersion"]),
                            Año = Convert.ToString(Dr["Año"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }
        public List<Modelo> Listadomodeloporversion(string cod, string nom)
        {
            List<Modelo> productos = new List<Modelo>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Versions
                string CdSql = "select Modelo.* from modelo, ModeloVersion,version, Vehiculo\r\n" +
                    "where modelo.IDModelo=ModeloVersion.IDModelo and ModeloVersion.IDVersion=Version.IDVersion\r\nand Version.IDVehiculo=Vehiculo.IDVehiculo and Vehiculo.Nombre=@Cl and Version.Version=@C";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", cod);
                    Cmd.Parameters.AddWithValue("@C", nom);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Modelo Pqte = new Modelo
                        {
                            IDModelo = Convert.ToString(Dr["IDModelo"]),
                            Año = Convert.ToString(Dr["Año"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<Versions> ListadoVersionPorVehiculo(string cod)
        {
            List<Versions> productos = new List<Versions>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Versions
                string CdSql = "select * from Version,Vehiculo where Version.IDVehiculo=Vehiculo.IDVehiculo and Vehiculo.Nombre=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", cod);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Versions Pqte = new Versions
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDVehiculo = Convert.ToString(Dr["IDvehiculo"]),
                            Llantas = Convert.ToString(Dr["LLantas"]),
                            TipoAsientos = Convert.ToString(Dr["TipoAsientos"]),
                            CamaraTrasera = Convert.ToString(Dr["CamaraTrasera"]),
                            Pantalla = Convert.ToString(Dr["Pantalla"]),
                            TipoCombustible = Convert.ToString(Dr["tipoCombustible"]),

                            Version = Convert.ToString(Dr["Version"]),
                            Rines = Convert.ToString(Dr["Rines"]),

                            Cilindraje = Convert.ToString(Dr["Cilindraje"]),
                            Costo = Convert.ToDouble(Dr["Costo"]),
                            CapacidadCajuela = Convert.ToString(Dr["Capacidadcajuela"]),
                            DistanciaEjes = Convert.ToString(Dr["DistanciaEjes"]),
                            Anchura = Convert.ToString(Dr["Anchura"]),
                            Altura = Convert.ToString(Dr["Altura"]),
                            AudioVelC = Convert.ToString(Dr["AudioVelC"]),
                            TomaCorriente = Convert.ToString(Dr["TomaCorriente"]),
                            TipoTraccion = Convert.ToString(Dr["TipoTraccion"]),
                            NumPuertas = Convert.ToString(Dr["NumPuertas"]),
                            Transmision = Convert.ToString(Dr["Transmision"]),
                            FarosHal = Convert.ToString(Dr["FarosHal"]),
                            NumEngranajes = Convert.ToString(Dr["NumEngranajes"]),
                            ACAutom = Convert.ToString(Dr["ACAutom"]),
                            FarosLED = Convert.ToString(Dr["FarosLED"]),
                            RendimientoCombustible = Convert.ToString(Dr["RendimientoCombustible"]),
                            FrenosTraseros = Convert.ToString(Dr["FrenosTraseros"]),
                            FrenosDelanteros = Convert.ToString(Dr["FrenosDelanteros"]),
                            SuspensionDelantera = Convert.ToString(Dr["SuspensionDelantera"]),
                            SuspensionTrasera = Convert.ToString(Dr["SuspensionTrasera"]),
                            EspejosLatDirC = Convert.ToString(Dr["EspejosLatDirC"]),
                            EspejosLatAE = Convert.ToString(Dr["EspejosLatAE"]),
                            EstadoVersion = Convert.ToString(Dr["EstadoVersion"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public Versions ObtenerPdtoPorNombreModelo(string CodPqt,string IDVehiculo)
        {
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM Version INNER JOIN Vehiculo on Version.IDVehiculo = Vehiculo.IDVehiculo WHERE Version.Version=@Cl and Vehiculo.Nombre=@Lc";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    Cmd.Parameters.AddWithValue("@Lc", IDVehiculo);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        Versions Pqte = new Versions
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDVehiculo = Convert.ToString(Dr["IDVehiculo"]),
                            Llantas = Convert.ToString(Dr["Llantas"]),
                            TipoAsientos = Convert.ToString(Dr["TipoAsientos"]),
                            CamaraTrasera = Convert.ToString(Dr["CamaraTrasera"]),
                            Pantalla = Convert.ToString(Dr["Pantalla"]),
                            TipoCombustible = Convert.ToString(Dr["TipoCombustible"]),
                            Version = Convert.ToString(Dr["Version"]),
                            Rines = Convert.ToString(Dr["Rines"]),
                            Cilindraje = Convert.ToString(Dr["Cilindraje"]),
                            Costo = Convert.ToDouble(Dr["Costo"]),
                            CapacidadCajuela = Convert.ToString(Dr["CapacidadCajuela"]),
                            DistanciaEjes = Convert.ToString(Dr["DistanciaEjes"]),
                            Anchura = Convert.ToString(Dr["Anchura"]),
                            Altura = Convert.ToString(Dr["Altura"]),
                            AudioVelC = Convert.ToString(Dr["AudioVelC"]),
                            TomaCorriente = Convert.ToString(Dr["TomaCorriente"]),
                            TipoTraccion = Convert.ToString(Dr["TipoTraccion"]),
                            NumPuertas = Convert.ToString(Dr["NumPuertas"]),
                            Transmision = Convert.ToString(Dr["Transmision"]),
                            FarosHal = Convert.ToString(Dr["FarosHal"]),
                            NumEngranajes = Convert.ToString(Dr["NumEngranajes"]),
                            ACAutom = Convert.ToString(Dr["ACAutom"]),
                            FarosLED = Convert.ToString(Dr["FarosLED"]),
                            RendimientoCombustible = Convert.ToString(Dr["RendimientoCombustible"]),
                            FrenosTraseros = Convert.ToString(Dr["FrenosTraseros"]),
                            FrenosDelanteros = Convert.ToString(Dr["FrenosDelanteros"]),
                            SuspensionDelantera = Convert.ToString(Dr["SuspensionDelantera"]),
                            SuspensionTrasera = Convert.ToString(Dr["SuspensionTrasera"]),
                            EspejosLatDirC = Convert.ToString(Dr["EspejosLatDirC"]),
                            EspejosLatAE = Convert.ToString(Dr["EspejosLatAE"]),
                            EstadoVersion = Convert.ToString(Dr["EstadoVersion"]),
                            Año = Convert.ToString(Dr["Año"])
                        };
                        return Pqte;
                    }
                }
                Cnx.Close();
            }
            return null;
        }
        public List <Versions> ObtenerPdtoPorNombreModeloListado(string CodPqt, string IDVehiculo)
        {
            List<Versions> productos = new List<Versions>();
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT * FROM Version INNER JOIN Vehiculo on Version.IDVehiculo = Vehiculo.IDVehiculo WHERE Version.Version=@Cl and Vehiculo.Nombre=@Lc";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    Cmd.Parameters.AddWithValue("@Lc", IDVehiculo);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Versions Pqte = new Versions
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDVehiculo = Convert.ToString(Dr["IDvehiculo"]),
                            Llantas = Convert.ToString(Dr["LLantas"]),
                            TipoAsientos = Convert.ToString(Dr["TipoAsientos"]),
                            CamaraTrasera = Convert.ToString(Dr["CamaraTrasera"]),
                            Pantalla = Convert.ToString(Dr["Pantalla"]),
                            TipoCombustible = Convert.ToString(Dr["tipoCombustible"]),

                            Version = Convert.ToString(Dr["Version"]),
                            Rines = Convert.ToString(Dr["Rines"]),

                            Cilindraje = Convert.ToString(Dr["Cilindraje"]),
                            Costo = Convert.ToDouble(Dr["Costo"]),
                            CapacidadCajuela = Convert.ToString(Dr["Capacidadcajuela"]),
                            DistanciaEjes = Convert.ToString(Dr["DistanciaEjes"]),
                            Anchura = Convert.ToString(Dr["Anchura"]),
                            Altura = Convert.ToString(Dr["Altura"]),
                            AudioVelC = Convert.ToString(Dr["AudioVelC"]),
                            TomaCorriente = Convert.ToString(Dr["TomaCorriente"]),
                            TipoTraccion = Convert.ToString(Dr["TipoTraccion"]),
                            NumPuertas = Convert.ToString(Dr["NumPuertas"]),
                            Transmision = Convert.ToString(Dr["Transmision"]),
                            FarosHal = Convert.ToString(Dr["FarosHal"]),
                            NumEngranajes = Convert.ToString(Dr["NumEngranajes"]),
                            ACAutom = Convert.ToString(Dr["ACAutom"]),
                            FarosLED = Convert.ToString(Dr["FarosLED"]),
                            RendimientoCombustible = Convert.ToString(Dr["RendimientoCombustible"]),
                            FrenosTraseros = Convert.ToString(Dr["FrenosTraseros"]),
                            FrenosDelanteros = Convert.ToString(Dr["FrenosDelanteros"]),
                            SuspensionDelantera = Convert.ToString(Dr["SuspensionDelantera"]),
                            SuspensionTrasera = Convert.ToString(Dr["SuspensionTrasera"]),
                            EspejosLatDirC = Convert.ToString(Dr["EspejosLatDirC"]),
                            EspejosLatAE = Convert.ToString(Dr["EspejosLatAE"]),
                            EstadoVersion = Convert.ToString(Dr["EstadoVersion"]),
                            Año = Convert.ToString(Dr["Año"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<Versions> ObtenerVersionesDeVehiculo(string Nombre)
        {
            List<Versions> productos = new List<Versions>();
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "Select * " +
                    "from \r\nVersion v inner Join Vehiculo Veh on v.IDVehiculo=Veh.IDVehiculo \r\n" +
                    "where veh.Nombre=@Cl";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", Nombre);
                    
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Versions Pqte = new Versions
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDVehiculo = Convert.ToString(Dr["IDvehiculo"]),
                            Llantas = Convert.ToString(Dr["LLantas"]),
                            TipoAsientos = Convert.ToString(Dr["TipoAsientos"]),
                            CamaraTrasera = Convert.ToString(Dr["CamaraTrasera"]),
                            Pantalla = Convert.ToString(Dr["Pantalla"]),
                            TipoCombustible = Convert.ToString(Dr["tipoCombustible"]),

                            Version = Convert.ToString(Dr["Version"]),
                            Rines = Convert.ToString(Dr["Rines"]),

                            Cilindraje = Convert.ToString(Dr["Cilindraje"]),
                            Costo = Convert.ToDouble(Dr["Costo"]),
                            CapacidadCajuela = Convert.ToString(Dr["Capacidadcajuela"]),
                            DistanciaEjes = Convert.ToString(Dr["DistanciaEjes"]),
                            Anchura = Convert.ToString(Dr["Anchura"]),
                            Altura = Convert.ToString(Dr["Altura"]),
                            AudioVelC = Convert.ToString(Dr["AudioVelC"]),
                            TomaCorriente = Convert.ToString(Dr["TomaCorriente"]),
                            TipoTraccion = Convert.ToString(Dr["TipoTraccion"]),
                            NumPuertas = Convert.ToString(Dr["NumPuertas"]),
                            Transmision = Convert.ToString(Dr["Transmision"]),
                            FarosHal = Convert.ToString(Dr["FarosHal"]),
                            NumEngranajes = Convert.ToString(Dr["NumEngranajes"]),
                            ACAutom = Convert.ToString(Dr["ACAutom"]),
                            FarosLED = Convert.ToString(Dr["FarosLED"]),
                            RendimientoCombustible = Convert.ToString(Dr["RendimientoCombustible"]),
                            FrenosTraseros = Convert.ToString(Dr["FrenosTraseros"]),
                            FrenosDelanteros = Convert.ToString(Dr["FrenosDelanteros"]),
                            SuspensionDelantera = Convert.ToString(Dr["SuspensionDelantera"]),
                            SuspensionTrasera = Convert.ToString(Dr["SuspensionTrasera"]),
                            EspejosLatDirC = Convert.ToString(Dr["EspejosLatDirC"]),
                            EspejosLatAE = Convert.ToString(Dr["EspejosLatAE"]),
                            EstadoVersion = Convert.ToString(Dr["EstadoVersion"]),
                            Año = Convert.ToString(Dr["Año"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<Versions> ListadoTotal()
        {
            List<Versions> productos = new List<Versions>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Versions
                string CdSql = "Select * from Version";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Versions Pqte = new Versions
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            IDVehiculo = Convert.ToString(Dr["IDvehiculo"]),
                            Llantas = Convert.ToString(Dr["LLantas"]),
                            TipoAsientos = Convert.ToString(Dr["TipoAsientos"]),
                            CamaraTrasera = Convert.ToString(Dr["CamaraTrasera"]),
                            Pantalla = Convert.ToString(Dr["Pantalla"]),
                            TipoCombustible = Convert.ToString(Dr["tipoCombustible"]),

                            Version = Convert.ToString(Dr["Version"]),
                            Rines = Convert.ToString(Dr["Rines"]),

                            Cilindraje = Convert.ToString(Dr["Cilindraje"]),
                            Costo = Convert.ToDouble(Dr["Costo"]),
                            CapacidadCajuela = Convert.ToString(Dr["Capacidadcajuela"]),
                            DistanciaEjes = Convert.ToString(Dr["DistanciaEjes"]),
                            Anchura = Convert.ToString(Dr["Anchura"]),
                            Altura = Convert.ToString(Dr["Altura"]),
                            AudioVelC = Convert.ToString(Dr["AudioVelC"]),
                            TomaCorriente = Convert.ToString(Dr["TomaCorriente"]),
                            TipoTraccion = Convert.ToString(Dr["TipoTraccion"]),
                            NumPuertas = Convert.ToString(Dr["NumPuertas"]),
                            Transmision = Convert.ToString(Dr["Transmision"]),
                            FarosHal = Convert.ToString(Dr["FarosHal"]),
                            NumEngranajes = Convert.ToString(Dr["NumEngranajes"]),
                            ACAutom = Convert.ToString(Dr["ACAutom"]),
                            FarosLED = Convert.ToString(Dr["FarosLED"]),
                            RendimientoCombustible = Convert.ToString(Dr["RendimientoCombustible"]),
                            FrenosTraseros = Convert.ToString(Dr["FrenosTraseros"]),
                            FrenosDelanteros = Convert.ToString(Dr["FrenosDelanteros"]),
                            SuspensionDelantera = Convert.ToString(Dr["SuspensionDelantera"]),
                            SuspensionTrasera = Convert.ToString(Dr["SuspensionTrasera"]),
                            EspejosLatDirC = Convert.ToString(Dr["EspejosLatDirC"]),
                            EspejosLatAE = Convert.ToString(Dr["EspejosLatAE"]),
                            EstadoVersion = Convert.ToString(Dr["EstadoVersion"]),
                            Año = Convert.ToString(Dr["Año"])
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
                string CdSql = "Update Version SET EstadoVersion='Inactivo' WHERE IDVersion=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    Cmd.Parameters.AddWithValue("@Cl", CodPqt);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                Cnx.Close();
            }



        }

        public void Actualizar(Versions Pqte)
        {
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                string CdSql = "UPDATE Version SET IDVehiculo=@Ve ,Llantas=@L ,TipoAsientos=@TA,CamaraTrasera =@CT,Pantalla=@P,TipoCombustible=@TC,Version=@V,Rines=@R,Cilindraje=@Ci,Costo=@Co,CapacidadCajuela=@CC,DistanciaEjes=@DE,Anchura=@At,Altura=@Al,AudioVelC=@AVC,TomaCorriente=@TCO,TipoTraccion=@TT,NumPuertas=@NP,Transmision=@Trans,FarosHal=@FH,NumEngranajes=@NumEng,ACAutom=@ACA,FarosLED=@FLED,RendimientoCombustible=@RCom,FrenosTraseros=@FTr,FrenosDelanteros=@FDl,SuspensionDelantera=@SD,SuspensionTrasera=@ST,EspejosLatDirC=@ELDC,EspejosLatAE=@ELAE,EstadoVersion=@EsV,Año=@An WHERE IDVersion=@Cl";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Añadir los parámetros
                    Cmd.Parameters.AddWithValue("@Cl", Pqte.IDVersion);//Get y set de la capa entidad
                    Cmd.Parameters.AddWithValue("@Ve", Pqte.IDVehiculo);
                    Cmd.Parameters.AddWithValue("@L", Pqte.Llantas);
                    Cmd.Parameters.AddWithValue("@TA", Pqte.TipoAsientos);
                    Cmd.Parameters.AddWithValue("@CT", Pqte.CamaraTrasera);
                    Cmd.Parameters.AddWithValue("@P", Pqte.Pantalla);
                    Cmd.Parameters.AddWithValue("@TC", Pqte.TipoCombustible);
                    Cmd.Parameters.AddWithValue("@V", Pqte.Version);
                    Cmd.Parameters.AddWithValue("@R", Pqte.Rines);
                    Cmd.Parameters.AddWithValue("@Ci", Pqte.Cilindraje);
                    Cmd.Parameters.AddWithValue("@Co", Pqte.Costo);
                    Cmd.Parameters.AddWithValue("@CC", Pqte.CapacidadCajuela);
                    Cmd.Parameters.AddWithValue("@DE", Pqte.DistanciaEjes);
                    Cmd.Parameters.AddWithValue("@At", Pqte.Anchura);
                    Cmd.Parameters.AddWithValue("@Al", Pqte.Altura);
                    Cmd.Parameters.AddWithValue("@AVC", Pqte.AudioVelC);
                    Cmd.Parameters.AddWithValue("@TCO", Pqte.TomaCorriente);
                    Cmd.Parameters.AddWithValue("@TT", Pqte.TipoTraccion);
                    Cmd.Parameters.AddWithValue("@NP", Pqte.NumPuertas);
                    Cmd.Parameters.AddWithValue("@Trans", Pqte.Transmision);
                    Cmd.Parameters.AddWithValue("@FH", Pqte.FarosHal);
                    Cmd.Parameters.AddWithValue("@NumEng", Pqte.NumEngranajes);
                    Cmd.Parameters.AddWithValue("@ACA", Pqte.ACAutom);
                    Cmd.Parameters.AddWithValue("@FLED", Pqte.FarosLED);
                    Cmd.Parameters.AddWithValue("@RCom", Pqte.RendimientoCombustible);
                    Cmd.Parameters.AddWithValue("@FTr", Pqte.FrenosTraseros);
                    Cmd.Parameters.AddWithValue("@FDl", Pqte.FrenosDelanteros);
                    Cmd.Parameters.AddWithValue("@SD", Pqte.SuspensionDelantera);
                    Cmd.Parameters.AddWithValue("@ST", Pqte.SuspensionTrasera);
                    Cmd.Parameters.AddWithValue("@ELDC", Pqte.EspejosLatDirC);
                    Cmd.Parameters.AddWithValue("@ELAE", Pqte.EspejosLatAE);
                    Cmd.Parameters.AddWithValue("@EsV", "Activo");
                    Cmd.Parameters.AddWithValue("@An", Pqte.Año);
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();
                }
                Cnx.Close();
            }
        }
    }
}
