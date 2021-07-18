using EntityFramework_ADONET.BEAN;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ADONET.DAO
{
    public class ViajeDAO
    {
        #region Cadena conexion
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD"].ConnectionString;
        #endregion

        //CREATE PROCEDURE SP_Viaje_Listar
        //as
        //select idViaje, idTarjeta, idPais, fechaInicioViaje, fechaFinViaje, estadoViaje from tbViaje
        public List<ViajeBEAN> ListarViaje()
        {
            List<ViajeBEAN> lista = new List<ViajeBEAN>();
            ViajeBEAN viaje;
            try
            {
                using (var con = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_Viaje_Listar", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                viaje = new ViajeBEAN();
                                viaje.IdViaje = Convert.ToInt32(dr[0]);
                                viaje.IdTarjeta = Convert.ToInt32(dr[1]);
                                viaje.IdPais = Convert.ToInt32(dr[2]);
                                viaje.FechaInicioViaje = Convert.ToDateTime(dr[3]);
                                viaje.FechaFinViaje = Convert.ToDateTime(dr[4]);
                                viaje.EstadoViaje = Convert.ToString(dr[5]);
                                lista.Add(viaje);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return lista;
        }


        //CREATE PROCEDURE SP_Viaje_Insert
        //(@idTarjeta int, @idPais int, @fechaInicioViaje datetime, @fechaFinViaje datetime, @estadoViaje nvarchar(1))
        //as
        //INSERT INTO tbViaje(idTarjeta, idPais, fechaInicioViaje, fechaFinViaje, estadoViaje)
        //values(@idTarjeta, @idPais, @fechaInicioViaje , @fechaFinViaje , @estadoViaje)
        public Boolean RegistrarRol(ViajeBEAN viaje)
        {
            bool rpta = false;
            try
            {
                using (var con = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_Viaje_Insert", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idTarjeta", viaje.IdTarjeta);
                        cmd.Parameters.AddWithValue("@idPais", viaje.IdPais);
                        cmd.Parameters.AddWithValue("@fechaInicioViaje", viaje.FechaInicioViaje);
                        cmd.Parameters.AddWithValue("@fechaFinViaje", viaje.FechaFinViaje);
                        cmd.Parameters.AddWithValue("@estadoViaje", viaje.EstadoViaje);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        rpta = true;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return rpta;
        }
        
    }
}
