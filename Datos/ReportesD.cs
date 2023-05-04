using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ReportesD
    {
        string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();


        public string GananciasDeUnCliente(string idcliente)
        {
            string ganancias="1224569";
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT COALESCE((\r\n  " +
                    "SELECT SUM(venC.TotalFinal)\r\n  " +
                    "FROM ((Cliente c\r\n  INNER JOIN Cotizacion co ON c.IDCliente = co.IDCliente)\r\n  INNER JOIN VentaCredito venC ON co.IDCotizacion = venC.IDCotizacion)\r\n  INNER JOIN Venta v ON v.IDVenta = venC.IDVenta\r\n  " +
                    "WHERE c.IDCliente =@Cl  \r\n), 0) + COALESCE((\r\n  " +
                    "SELECT SUM(vt.Subtotal)\r\n  " +
                    "FROM ((Cliente c\r\n  INNER JOIN Cotizacion co ON c.IDCliente = co.IDCliente)\r\n  INNER JOIN VentaContado venCt ON co.IDCotizacion = venCt.IDCotizacion)\r\n  INNER JOIN Venta vt ON vt.IDVenta = venCt.IDVenta\r\n  " +
                    "WHERE c.IDCliente =@Cl  \r\n), 0) AS totalgastado";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        ganancias = Convert.ToString(Dr["totalgastado"]);
                        return ganancias;
                    }
                    
                }
                Cnx.Close();
            }
            return null;
        }
        public string GananciasDeUnEmpleado(string idempleado)
        {
            string ganancias = "1224569";
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "Select SUM(v.Subtotal)+(COALESCE ((Select SUM(v.Subtotal) AS ingresoGenerado\r\n" +
                    "From ((Empleado e inner join Cotizacion co on e.IDEmpleado=co.IDEmpleado) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)inner join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "Where e.IDEmpleado=@Cl),0)) AS ingresoGenerado\r\n" +
                    "From ((Empleado e inner join Cotizacion co on e.IDEmpleado=co.IDEmpleado) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)inner join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "Where e.IDEmpleado=@Cl\r\n";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", idempleado);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        ganancias = Convert.ToString(Dr["ingresoGenerado"]);
                        return ganancias;
                    }

                }
                Cnx.Close();
            }
            return null;
        }

        public List<ReportesEntidad> ListadoClienteFrecuenteContadoDia(int DiaI,int MesI,int AnoI,int DiaF,int MesF,int AnoF)
        {
            List<ReportesEntidad> productos = new List<ReportesEntidad>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select  c.IDCliente,COUNT(*)AS vecesCompro from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\nwhere v.Dia Between "+DiaI.ToString()+" and "+DiaF.ToString()+" AND v.Mes="+MesF.ToString() +"and v.Año="+AnoF.ToString()+" \r\nGROUP BY c.IDCliente\r\nORDER BY vecescompro DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                         ReportesEntidad Pqte = new ReportesEntidad
                        {
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            vecesCompro = Convert.ToString(Dr["vecesCompro"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<ReportesEntidad> ListadoClienteFrecuenteCreditoDia( int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReportesEntidad> productos = new List<ReportesEntidad>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select  c.IDCliente,COUNT(*)AS vecesCompro from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\nwhere v.Dia Between " + DiaI.ToString() + " and " + DiaF.ToString() + " AND v.Mes=" + MesF.ToString() + "and v.Año=" + AnoF.ToString() + " \r\nGROUP BY c.IDCliente\r\nORDER BY vecescompro DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReportesEntidad Pqte = new ReportesEntidad
                        {
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            vecesCompro = Convert.ToString(Dr["vecesCompro"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReportesEntidad> ListadoClienteFrecuenteTotalDia(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReportesEntidad> productos = new List<ReportesEntidad>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "SELECT IDCliente, SUM(vecescompro) AS vecesCompro\r\n" +
                    "FROM (\r\n  Select c.IDCliente, COUNT(*) AS vecescompro\r\n  from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n  " +
                    "where v.Dia Between "+DiaI.ToString()+" and "+DiaF.ToString()+" AND v.Mes BETWEEN "+MesI.ToString()+" and "+MesF.ToString()+" and v.Año BETWEEN "+AnoI.ToString()+" and "+AnoF.ToString()+" \r\n  GROUP BY c.IDCliente\r\n  " +
                    "UNION ALL\r\n  Select c.IDCliente, COUNT(*) AS vecescompro\r\n  " +
                    "from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n  " +
                    "where v.Dia Between "+DiaI.ToString()+" and "+DiaF.ToString()+" AND v.Mes BETWEEN "+MesI.ToString()+" and "+MesF.ToString()+" and v.Año BETWEEN "+AnoI.ToString()+" and "+AnoF.ToString()+"\r\n  GROUP BY c.IDCliente\r\n) AS ventas\r\nGROUP BY IDCliente\r\nORDER BY vecesCompro DESC;";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReportesEntidad Pqte = new ReportesEntidad
                        {
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            vecesCompro = Convert.ToString(Dr["vecesCompro"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReportesEntidad> ListadoClienteFrecuenteTotalMes(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReportesEntidad> productos = new List<ReportesEntidad>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "SELECT IDCliente, SUM(vecescompro) AS vecesCompro\r\n" +
                    "FROM (\r\n  Select c.IDCliente, COUNT(*) AS vecescompro\r\n  from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n  " +
                    "where v.Mes BETWEEN " + MesI.ToString() + " and " + MesF.ToString() + " and v.Año BETWEEN " + AnoI.ToString() + " and " + AnoF.ToString() + " \r\n  GROUP BY c.IDCliente\r\n  " +
                    "UNION ALL\r\n  Select c.IDCliente, COUNT(*) AS vecescompro\r\n  " +
                    "from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n  " +
                    "where v.Mes BETWEEN " + MesI.ToString() + " and " + MesF.ToString() + " and v.Año BETWEEN " + AnoI.ToString() + " and " + AnoF.ToString() + "\r\n  GROUP BY c.IDCliente\r\n) AS ventas\r\nGROUP BY IDCliente\r\nORDER BY vecesCompro DESC;";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReportesEntidad Pqte = new ReportesEntidad
                        {
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            vecesCompro = Convert.ToString(Dr["vecesCompro"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReportesEntidad> ListadoClienteFrecuenteTotalAno(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReportesEntidad> productos = new List<ReportesEntidad>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "SELECT IDCliente, SUM(vecescompro) AS vecesCompro\r\n" +
                    "FROM (\r\n  Select c.IDCliente, COUNT(*) AS vecescompro\r\n  from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n  " +
                    "where v.Año BETWEEN " + AnoI.ToString() + " and " + AnoF.ToString() + " \r\n  GROUP BY c.IDCliente\r\n  " +
                    "UNION ALL\r\n  Select c.IDCliente, COUNT(*) AS vecescompro\r\n  " +
                    "from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n  " +
                    "where v.Año BETWEEN " + AnoI.ToString() + " and " + AnoF.ToString() + "\r\n  GROUP BY c.IDCliente\r\n) AS ventas\r\nGROUP BY IDCliente\r\nORDER BY vecesCompro DESC;";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReportesEntidad Pqte = new ReportesEntidad
                        {
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            vecesCompro = Convert.ToString(Dr["vecesCompro"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReportesEntidad> ListadoClienteFrecuenteContadoMes(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReportesEntidad> productos = new List<ReportesEntidad>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select  c.IDCliente,COUNT(*)AS vecesCompro from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\nwhere v.Mes BETWEEN "+MesI.ToString()+" and "+MesF.ToString()+" and v.Año="+AnoF.ToString()+" \r\nGROUP BY c.IDCliente\r\nORDER BY vecescompro DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReportesEntidad Pqte = new ReportesEntidad
                        {
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            vecesCompro = Convert.ToString(Dr["vecesCompro"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<ReportesEntidad> ListadoClienteFrecuenteCreditoMes(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReportesEntidad> productos = new List<ReportesEntidad>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select  c.IDCliente,COUNT(*)AS vecesCompro from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\nwhere v.Mes BETWEEN " + MesI.ToString() + " and " + MesF.ToString() + " and v.Año=" + AnoF.ToString() + " \r\nGROUP BY c.IDCliente\r\nORDER BY vecescompro DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReportesEntidad Pqte = new ReportesEntidad
                        {
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            vecesCompro = Convert.ToString(Dr["vecesCompro"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<ReportesEntidad> ListadoClienteFrecuenteContadoAno(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReportesEntidad> productos = new List<ReportesEntidad>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select  c.IDCliente,COUNT(*)AS vecesCompro from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "where  v.Año between "+AnoI.ToString()+" and "+AnoF.ToString()+"\r\nGROUP BY c.IDCliente\r\nORDER BY vecescompro DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReportesEntidad Pqte = new ReportesEntidad
                        {
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            vecesCompro = Convert.ToString(Dr["vecesCompro"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReportesEntidad> ListadoClienteFrecuenteCreditoAno(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReportesEntidad> productos = new List<ReportesEntidad>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select  c.IDCliente,COUNT(*)AS vecesCompro from ((Cliente c inner join Cotizacion co on c.IDCliente=co.IDCliente) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "where  v.Año between " + AnoI.ToString() + " and " + AnoF.ToString() + "\r\nGROUP BY c.IDCliente\r\nORDER BY vecescompro DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReportesEntidad Pqte = new ReportesEntidad
                        {
                            IDCliente = Convert.ToString(Dr["IDCliente"]),
                            vecesCompro = Convert.ToString(Dr["vecesCompro"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReporteVehiculoMasVendido> ListadoVehiculoMasVendidoContadoDia(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteVehiculoMasVendido> productos = new List<ReporteVehiculoMasVendido>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "select co.IDVersion ,COUNT(*)AS vecesVendido\r\n" +
                    "FROM (((Vehiculo v inner join Version ver on ver.IDVehiculo=v.IDVehiculo)inner join Cotizacion co on co.IDVersion = ver.IDVersion)inner join VentaContado venC on venC.IDCotizacion=co.IDCotizacion)inner join Venta ven on ven.IDVenta = venC.IDVenta\r\n" +
                    "where ven.Dia Between "+DiaI.ToString()+" and "+DiaF.ToString()+" AND ven.Mes="+MesF.ToString()+" and ven.Año="+AnoF.ToString()+" \r\nGROUP BY co.IDVersion\r\nORDER BY vecesVendido DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteVehiculoMasVendido Pqte = new ReporteVehiculoMasVendido
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            vecesVendido = Convert.ToString(Dr["vecesVendido"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReporteVehiculoMasVendido> ListadoVehiculoMasVendidoCreditoDia(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteVehiculoMasVendido> productos = new List<ReporteVehiculoMasVendido>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "select co.IDVersion ,COUNT(*)AS vecesVendido\r\n" +
                    "FROM (((Vehiculo v inner join Version ver on ver.IDVehiculo=v.IDVehiculo)inner join Cotizacion co on co.IDVersion = ver.IDVersion)inner join VentaCredito venC on venC.IDCotizacion=co.IDCotizacion)inner join Venta ven on ven.IDVenta = venC.IDVenta\r\n" +
                    "where ven.Dia Between " + DiaI.ToString() + " and " + DiaF.ToString() + " AND ven.Mes=" + MesF.ToString() + " and ven.Año=" + AnoF.ToString() + " \r\nGROUP BY co.IDVersion\r\nORDER BY vecesVendido DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteVehiculoMasVendido Pqte = new ReporteVehiculoMasVendido
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            vecesVendido = Convert.ToString(Dr["vecesVendido"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReporteVehiculoMasVendido> ListadoVehiculoMasVendidoTotalDia(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteVehiculoMasVendido> productos = new List<ReporteVehiculoMasVendido>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "SELECT IDVersion, SUM(VecesVendido) AS TotalVecesVendido\r\n" +
                    "FROM (\r\n    SELECT co.IDVersion, COUNT(*) AS VecesVendido\r\n    " +
                    "FROM (((Vehiculo v INNER JOIN Version ver ON ver.IDVehiculo=v.IDVehiculo) INNER JOIN Cotizacion co ON co.IDVersion = ver.IDVersion) INNER JOIN VentaContado venC ON venC.IDCotizacion=co.IDCotizacion) INNER JOIN Venta ven ON ven.IDVenta = venC.IDVenta\r\n    " +
                    "WHERE ven.Dia BETWEEN "+DiaI.ToString()+" AND "+DiaF.ToString()+" AND ven.Mes BETWEEN "+MesI.ToString()+" AND "+MesF.ToString()+" AND ven.Año BETWEEN "+AnoI.ToString()+" AND "+AnoF.ToString()+" \r\n    " +
                    "GROUP BY co.IDVersion\r\n    UNION ALL\r\n    " +
                    "SELECT co.IDVersion, COUNT(*) AS VecesVendido\r\n    " +
                    "FROM (((Vehiculo v INNER JOIN Version ver ON ver.IDVehiculo=v.IDVehiculo) INNER JOIN Cotizacion co ON co.IDVersion = ver.IDVersion) INNER JOIN VentaCredito venC ON venC.IDCotizacion=co.IDCotizacion) INNER JOIN Venta ven ON ven.IDVenta = venC.IDVenta\r\n    " +
                    "WHERE ven.Dia BETWEEN "+DiaI.ToString()+" AND "+DiaF.ToString()+" AND ven.Mes BETWEEN "+MesI.ToString()+" AND "+MesF.ToString()+" AND ven.Año BETWEEN "+AnoI.ToString()+" AND "+AnoF.ToString()+" \r\n    " +
                    "GROUP BY co.IDVersion\r\n) AS VehiculosTotales\r\nGROUP BY IDVersion\r\nORDER BY TotalVecesVendido DESC\r\n";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteVehiculoMasVendido Pqte = new ReporteVehiculoMasVendido
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            vecesVendido = Convert.ToString(Dr["TotalVecesVendido"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReporteVehiculoMasVendido> ListadoVehiculoMasVendidoTotalMes(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteVehiculoMasVendido> productos = new List<ReporteVehiculoMasVendido>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "SELECT IDVersion, SUM(VecesVendido) AS TotalVecesVendido\r\n" +
                    "FROM (\r\n    SELECT co.IDVersion, COUNT(*) AS VecesVendido\r\n    " +
                    "FROM (((Vehiculo v INNER JOIN Version ver ON ver.IDVehiculo=v.IDVehiculo) INNER JOIN Cotizacion co ON co.IDVersion = ver.IDVersion) INNER JOIN VentaContado venC ON venC.IDCotizacion=co.IDCotizacion) INNER JOIN Venta ven ON ven.IDVenta = venC.IDVenta\r\n    " +
                    "WHERE ven.Mes BETWEEN " + MesI.ToString() + " AND " + MesF.ToString() + " AND ven.Año BETWEEN " + AnoI.ToString() + " AND " + AnoF.ToString() + " \r\n    " +
                    "GROUP BY co.IDVersion\r\n    UNION ALL\r\n    " +
                    "SELECT co.IDVersion, COUNT(*) AS VecesVendido\r\n    " +
                    "FROM (((Vehiculo v INNER JOIN Version ver ON ver.IDVehiculo=v.IDVehiculo) INNER JOIN Cotizacion co ON co.IDVersion = ver.IDVersion) INNER JOIN VentaCredito venC ON venC.IDCotizacion=co.IDCotizacion) INNER JOIN Venta ven ON ven.IDVenta = venC.IDVenta\r\n    " +
                    "WHERE ven.Mes BETWEEN " + MesI.ToString() + " AND " + MesF.ToString() + " AND ven.Año BETWEEN " + AnoI.ToString() + " AND " + AnoF.ToString() + " \r\n    " +
                    "GROUP BY co.IDVersion\r\n) AS VehiculosTotales\r\nGROUP BY IDVersion\r\nORDER BY TotalVecesVendido DESC\r\n";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteVehiculoMasVendido Pqte = new ReporteVehiculoMasVendido
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            vecesVendido = Convert.ToString(Dr["TotalVecesVendido"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReporteVehiculoMasVendido> ListadoVehiculoMasVendidoTotalAno(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteVehiculoMasVendido> productos = new List<ReporteVehiculoMasVendido>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "SELECT IDVersion, SUM(VecesVendido) AS TotalVecesVendido\r\n" +
                    "FROM (\r\n    SELECT co.IDVersion, COUNT(*) AS VecesVendido\r\n    " +
                    "FROM (((Vehiculo v INNER JOIN Version ver ON ver.IDVehiculo=v.IDVehiculo) INNER JOIN Cotizacion co ON co.IDVersion = ver.IDVersion) INNER JOIN VentaContado venC ON venC.IDCotizacion=co.IDCotizacion) INNER JOIN Venta ven ON ven.IDVenta = venC.IDVenta\r\n    " +
                    "WHERE ven.Año BETWEEN " + AnoI.ToString() + " AND " + AnoF.ToString() + " \r\n    " +
                    "GROUP BY co.IDVersion\r\n    UNION ALL\r\n    " +
                    "SELECT co.IDVersion, COUNT(*) AS VecesVendido\r\n    " +
                    "FROM (((Vehiculo v INNER JOIN Version ver ON ver.IDVehiculo=v.IDVehiculo) INNER JOIN Cotizacion co ON co.IDVersion = ver.IDVersion) INNER JOIN VentaCredito venC ON venC.IDCotizacion=co.IDCotizacion) INNER JOIN Venta ven ON ven.IDVenta = venC.IDVenta\r\n    " +
                    "WHERE ven.Año BETWEEN " + AnoI.ToString() + " AND " + AnoF.ToString() + " \r\n    " +
                    "GROUP BY co.IDVersion\r\n) AS VehiculosTotales\r\nGROUP BY IDVersion\r\nORDER BY TotalVecesVendido DESC\r\n";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteVehiculoMasVendido Pqte = new ReporteVehiculoMasVendido
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            vecesVendido = Convert.ToString(Dr["TotalVecesVendido"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<ReporteVehiculoMasVendido> ListadoVehiculoMasVendidoContadoMes(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteVehiculoMasVendido> productos = new List<ReporteVehiculoMasVendido>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "select co.IDVersion ,COUNT(*)AS vecesVendido\r\n" +
                    "FROM (((Vehiculo v inner join Version ver on ver.IDVehiculo=v.IDVehiculo)inner join Cotizacion co on co.IDVersion = ver.IDVersion)inner join VentaContado venC on venC.IDCotizacion=co.IDCotizacion)inner join Venta ven on ven.IDVenta = venC.IDVenta\r\n" +
                    "where ven.Mes BETWEEN " + MesI.ToString() + " and "+MesF.ToString() +"AND ven.Año=" + AnoF.ToString() + " \r\nGROUP BY co.IDVersion\r\nORDER BY vecesVendido DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteVehiculoMasVendido Pqte = new ReporteVehiculoMasVendido
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            vecesVendido = Convert.ToString(Dr["vecesVendido"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReporteVehiculoMasVendido> ListadoVehiculoMasVendidoCreditoMes(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteVehiculoMasVendido> productos = new List<ReporteVehiculoMasVendido>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "select co.IDVersion ,COUNT(*)AS vecesVendido\r\n" +
                    "FROM (((Vehiculo v inner join Version ver on ver.IDVehiculo=v.IDVehiculo)inner join Cotizacion co on co.IDVersion = ver.IDVersion)inner join VentaCredito venC on venC.IDCotizacion=co.IDCotizacion)inner join Venta ven on ven.IDVenta = venC.IDVenta\r\n" +
                    "where ven.Mes BETWEEN " + MesI.ToString() + " and " + MesF.ToString() + "AND ven.Año=" + AnoF.ToString() + " \r\nGROUP BY co.IDVersion\r\nORDER BY vecesVendido DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteVehiculoMasVendido Pqte = new ReporteVehiculoMasVendido
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            vecesVendido = Convert.ToString(Dr["vecesVendido"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReporteVehiculoMasVendido> ListadoVehiculoMasVendidoContadoAno(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteVehiculoMasVendido> productos = new List<ReporteVehiculoMasVendido>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "select co.IDVersion ,COUNT(*)AS vecesVendido\r\n" +
                    "FROM (((Vehiculo v inner join Version ver on ver.IDVehiculo=v.IDVehiculo)inner join Cotizacion co on co.IDVersion = ver.IDVersion)inner join VentaContado venC on venC.IDCotizacion=co.IDCotizacion)inner join Venta ven on ven.IDVenta = venC.IDVenta\r\n" +
                    "where ven.Año between "+AnoI.ToString() +" and "+ AnoF.ToString()+" \r\n" +
                    "GROUP BY co.IDVersion\r\nORDER BY vecesVendido DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteVehiculoMasVendido Pqte = new ReporteVehiculoMasVendido
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            vecesVendido = Convert.ToString(Dr["vecesVendido"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReporteVehiculoMasVendido> ListadoVehiculoMasVendidoCreditoAno(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteVehiculoMasVendido> productos = new List<ReporteVehiculoMasVendido>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "select co.IDVersion ,COUNT(*)AS vecesVendido\r\n" +
                    "FROM (((Vehiculo v inner join Version ver on ver.IDVehiculo=v.IDVehiculo)inner join Cotizacion co on co.IDVersion = ver.IDVersion)inner join VentaContado venC on venC.IDCotizacion=co.IDCotizacion)inner join Venta ven on ven.IDVenta = venC.IDVenta\r\n" +
                    "where ven.Año between " + AnoI.ToString() + " and " + AnoF.ToString() + " \r\n" +
                    "GROUP BY co.IDVersion\r\nORDER BY vecesVendido DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteVehiculoMasVendido Pqte = new ReporteVehiculoMasVendido
                        {
                            IDVersion = Convert.ToString(Dr["IDVersion"]),
                            vecesVendido = Convert.ToString(Dr["vecesVendido"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public string GananciasDeUnaVersion(string idversion)
        {
            string ganancias ;
            //Using que crea la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                //Abro la conexión y creo el Query insertar, eliminar, consultar, elminar, actualizar, consulta individaul, general, orrar todo
                Cnx.Open();
                string CdSql = "SELECT COALESCE((\r\n  " +
                    "SELECT SUM(venC.TotalFinal)\r\n  " +
                    "FROM ((Cliente c\r\n  INNER JOIN Cotizacion co ON c.IDCliente = co.IDCliente)\r\n  INNER JOIN VentaCredito venC ON co.IDCotizacion = venC.IDCotizacion)\r\n  INNER JOIN Venta v ON v.IDVenta = venC.IDVenta\r\n  " +
                    "WHERE co.IDVersion =@Cl  \r\n), 0) + COALESCE((\r\n  " +
                    "SELECT SUM(vt.Subtotal)\r\n  " +
                    "FROM ((Cliente c\r\n  INNER JOIN Cotizacion co ON c.IDCliente = co.IDCliente)\r\n  INNER JOIN VentaContado venCt ON co.IDCotizacion = venCt.IDCotizacion)\r\n  INNER JOIN Venta vt ON vt.IDVenta = venCt.IDVenta\r\n  " +
                    "WHERE co.IDVersion =@Cl  \r\n), 0) AS totalgastado";
                //Using que crea el comando que voy a ejecutar con relación al query que planeteo
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    Cmd.Parameters.AddWithValue("@Cl", idversion);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    if (Dr.Read())
                    {

                        ganancias = Convert.ToString(Dr["totalgastado"]);
                        return ganancias;
                    }

                }
                Cnx.Close();
            }
            return null;
        }

        public List<ReporteEmpleadoVenta> ListadoEmpleadoVentaContadoDia(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteEmpleadoVenta> productos = new List<ReporteEmpleadoVenta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select e.IDEmpleado,COUNT(*)AS VentasRealizadas\r\n" +
                    "From ((Empleado e inner join Cotizacion co on e.IDEmpleado=co.IDEmpleado) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)inner join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "where v.Dia Between "+DiaI.ToString()+" and "+DiaF.ToString()+" AND v.Mes="+MesF.ToString()+" and v.Año="+AnoF.ToString()+" \r\nGROUP BY e.IDEmpleado\r\nORDER BY VentasRealizadas DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteEmpleadoVenta Pqte = new ReporteEmpleadoVenta
                        {
                             IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                             VentasRealizadas = Convert.ToString(Dr["VentasRealizadas"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<ReporteEmpleadoVenta> ListadoEmpleadoVentaCreditoDia(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteEmpleadoVenta> productos = new List<ReporteEmpleadoVenta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select e.IDEmpleado,COUNT(*)AS VentasRealizadas\r\n" +
                    "From ((Empleado e inner join Cotizacion co on e.IDEmpleado=co.IDEmpleado) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)inner join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "where v.Dia Between " + DiaI.ToString() + " and " + DiaF.ToString() + " AND v.Mes=" + MesF.ToString() + " and v.Año=" + AnoF.ToString() + " \r\nGROUP BY e.IDEmpleado\r\nORDER BY VentasRealizadas DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteEmpleadoVenta Pqte = new ReporteEmpleadoVenta
                        {
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            VentasRealizadas = Convert.ToString(Dr["VentasRealizadas"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<ReporteEmpleadoVenta> ListadoEmpleadoVentaContadoMes(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteEmpleadoVenta> productos = new List<ReporteEmpleadoVenta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select e.IDEmpleado,COUNT(*)AS VentasRealizadas\r\n" +
                    "From ((Empleado e inner join Cotizacion co on e.IDEmpleado=co.IDEmpleado) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)inner join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "where v.Mes BETWEEN "+MesI.ToString()+" and "+MesF.ToString()+" and v.Año="+AnoF.ToString()+" \r\n" +
                    "GROUP BY e.IDEmpleado\r\nORDER BY VentasRealizadas DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteEmpleadoVenta Pqte = new ReporteEmpleadoVenta
                        {
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            VentasRealizadas = Convert.ToString(Dr["VentasRealizadas"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<ReporteEmpleadoVenta> ListadoEmpleadoVentaCreditoMes(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteEmpleadoVenta> productos = new List<ReporteEmpleadoVenta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select e.IDEmpleado,COUNT(*)AS VentasRealizadas\r\n" +
                    "From ((Empleado e inner join Cotizacion co on e.IDEmpleado=co.IDEmpleado) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)inner join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "where v.Mes BETWEEN " + MesI.ToString() + " and " + MesF.ToString() + " and v.Año=" + AnoF.ToString() + " \r\n" +
                    "GROUP BY e.IDEmpleado\r\nORDER BY VentasRealizadas DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteEmpleadoVenta Pqte = new ReporteEmpleadoVenta
                        {
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            VentasRealizadas = Convert.ToString(Dr["VentasRealizadas"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }


        public List<ReporteEmpleadoVenta> ListadoEmpleadoVentaContadoAno(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteEmpleadoVenta> productos = new List<ReporteEmpleadoVenta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select e.IDEmpleado,COUNT(*)AS VentasRealizadas\r\n" +
                    "From ((Empleado e inner join Cotizacion co on e.IDEmpleado=co.IDEmpleado) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)inner join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "where  v.Año between "+AnoI.ToString()+" and "+AnoF.ToString()+"\r\nGROUP BY e.IDEmpleado\r\nORDER BY VentasRealizadas DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteEmpleadoVenta Pqte = new ReporteEmpleadoVenta
                        {
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            VentasRealizadas = Convert.ToString(Dr["VentasRealizadas"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<ReporteEmpleadoVenta> ListadoEmpleadoVentaCreditoAno(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteEmpleadoVenta> productos = new List<ReporteEmpleadoVenta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "Select e.IDEmpleado,COUNT(*)AS VentasRealizadas\r\n" +
                    "From ((Empleado e inner join Cotizacion co on e.IDEmpleado=co.IDEmpleado) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)inner join Venta v on v.IDVenta=venC.IDVenta\r\n" +
                    "where  v.Año between " + AnoI.ToString() + " and " + AnoF.ToString() + "\r\nGROUP BY e.IDEmpleado\r\nORDER BY VentasRealizadas DESC ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteEmpleadoVenta Pqte = new ReporteEmpleadoVenta
                        {
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            VentasRealizadas = Convert.ToString(Dr["VentasRealizadas"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<ReporteEmpleadoVenta> ListadoEmpleadoVentaTotalDia(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<ReporteEmpleadoVenta> productos = new List<ReporteEmpleadoVenta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query 
                string CdSql = "SELECT IDEmpleado, SUM(vecescompro) AS vecesCompro\r\nFROM (\r\n  " +
                    "Select c.IDEmpleado, COUNT(*) AS vecescompro\r\n  " +
                    "from ((Empleado c inner join Cotizacion co on c.IDEmpleado=co.IDEmpleado) inner join VentaContado venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n  " +
                    "where v.Dia Between "+DiaI.ToString()+" and "+DiaF.ToString()+" AND v.Mes BETWEEN "+MesI.ToString()+" and "+MesF.ToString()+" and v.Año BETWEEN "+AnoI.ToString()+" and "+AnoF.ToString()+" \r\n  " +
                    "GROUP BY c.IDEmpleado\r\n  " +
                    "UNION ALL\r\n  " +
                    "Select c.IDEmpleado, COUNT(*) AS vecescompro\r\n  " +
                    "from ((Empleado c inner join Cotizacion co on c.IDEmpleado=co.IDEmpleado) inner join VentaCredito venC on co.IDCotizacion=venC.IDCotizacion)Inner Join Venta v on v.IDVenta=venC.IDVenta\r\n  " +
                    "where v.Dia Between "+DiaI.ToString()+" and "+DiaF.ToString()+" AND v.Mes BETWEEN "+MesI.ToString()+" and "+MesF.ToString()+" and v.Año BETWEEN "+AnoI.ToString()+" and "+AnoF.ToString()+" \r\n  " +
                    "GROUP BY c.IDEmpleado\r\n) AS ventas\r\nGROUP BY IDEmpleado\r\nORDER BY vecesCompro DESC;\r\n";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    //Asignar el valor a @Cl
                    //Cmd.Parameters.AddWithValue("@Cl", idcliente);
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        ReporteEmpleadoVenta Pqte = new ReporteEmpleadoVenta
                        {
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            VentasRealizadas = Convert.ToString(Dr["VentasRealizadas"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<Venta> ListadoVentasPorDia(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<Venta> productos = new List<Venta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select * from Venta " +
                    "where Dia Between "+DiaI.ToString()+" and "+DiaF.ToString()+" AND Mes="+MesF.ToString()+" and Año="+AnoF.ToString()+"";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Venta Pqte = new Venta
                        {
                            IDVenta = Convert.ToString(Dr["IDVenta"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            NoSerie = Convert.ToString(Dr["NoSerie"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            Subtotal = Convert.ToDouble(Dr["SubTotal"]),
                            TipoVenta = Convert.ToString(Dr["TipoVenta"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }

        public List<Venta> ListadoVentasPorMes(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<Venta> productos = new List<Venta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select * \r\nfrom Venta \r\nwhere Mes BETWEEN "+MesI.ToString()+" and "+MesF.ToString()+" and Año=2023 ";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Venta Pqte = new Venta
                        {
                            IDVenta = Convert.ToString(Dr["IDVenta"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            NoSerie = Convert.ToString(Dr["NoSerie"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            Subtotal = Convert.ToDouble(Dr["SubTotal"]),
                            TipoVenta = Convert.ToString(Dr["TipoVenta"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        public List<Venta> ListadoVentasPorAno(int DiaI, int MesI, int AnoI, int DiaF, int MesF, int AnoF)
        {
            List<Venta> productos = new List<Venta>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla Venta
                string CdSql = "Select * \r\nfrom Venta \r\nwhere Año between "+AnoI.ToString()+" and "+AnoF.ToString()+"";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Venta Pqte = new Venta
                        {
                            IDVenta = Convert.ToString(Dr["IDVenta"]),
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            NoSerie = Convert.ToString(Dr["NoSerie"]),
                            Dia = Convert.ToInt32(Dr["Dia"]),
                            Mes = Convert.ToInt32(Dr["Mes"]),
                            Año = Convert.ToInt32(Dr["Año"]),
                            Hora = Convert.ToString(Dr["Hora"]),
                            Subtotal = Convert.ToDouble(Dr["SubTotal"]),
                            TipoVenta = Convert.ToString(Dr["TipoVenta"])
                        };
                        productos.Add(Pqte);
                    }
                }
                Cnx.Close();
            }
            return productos;
        }


    }
}
