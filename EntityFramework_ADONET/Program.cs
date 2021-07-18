using EntityFramework_ADONET.BEAN;
using EntityFramework_ADONET.DAO;
using EntityFramework_ADONET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpta = "N";
            do
            {
                Console.Clear();
                Console.WriteLine("Mantenimiento BD");
                Console.WriteLine("\n1 - CRUD Cliente");
                Console.WriteLine("2 - CRUD Tarjeta");
                Console.WriteLine("3 - CRUD Pais");
                Console.WriteLine("4 - CRUD Viaje");
                Console.WriteLine("\n Ingrese Opción: ");
                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {                    
                    case 1:
                        ClienteDAO cliDAO_EF = new ClienteDAO();
                        Console.Clear();
                        Console.WriteLine("Mantenimiento Cliente");
                        Console.WriteLine("\n1 - Registrar Cliente");
                        Console.WriteLine("2 - Listar Cliente");
                        Console.WriteLine("3 - Actualizar Cliente");
                        Console.WriteLine("\n Ingrese Opción: ");
                        int opcion1;
                        opcion1 = Convert.ToInt32(Console.ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                cliDAO_EF.RegistrarClienteEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 2:
                                cliDAO_EF.ListarClienteEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 3:
                                cliDAO_EF.ListarClienteEF();
                                cliDAO_EF.ActualizarClienteEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        TarjetaDAO tarjDAO_EF = new TarjetaDAO();
                        ClienteDAO cliDAO_EF1 = new ClienteDAO();
                        Console.Clear();
                        Console.WriteLine("Mantenimiento Tarjeta");
                        Console.WriteLine("\n1 - Registrar Tarjeta");
                        Console.WriteLine("2 - Listar Tarjeta");
                        Console.WriteLine("3 - Actualizar Tarjeta");
                        Console.WriteLine("\n Ingrese Opción: ");
                        int opcion2;
                        opcion2 = Convert.ToInt32(Console.ReadLine());
                        switch (opcion2)
                        {
                            case 1:
                                cliDAO_EF1.ListarClienteEF();
                                tarjDAO_EF.RegistrarTarjetaEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 2:
                                tarjDAO_EF.ListarTarjetaEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 3:
                                tarjDAO_EF.ListarTarjetaEF();
                                cliDAO_EF1.ListarClienteEF();
                                tarjDAO_EF.ActualizarTarjetaEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        PaisDAO paisDAO_EF = new PaisDAO();
                        Console.Clear();
                        Console.WriteLine("Mantenimiento País");
                        Console.WriteLine("\n1 - Registrar País");
                        Console.WriteLine("2 - Listar País");
                        Console.WriteLine("3 - Actualizar País");
                        Console.WriteLine("\n Ingrese Opción: ");
                        int opcion3;
                        opcion3 = Convert.ToInt32(Console.ReadLine());
                        switch (opcion3)
                        {
                            case 1:
                                paisDAO_EF.RegistrarPaisEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 2:
                                paisDAO_EF.ListarPaisEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 3:
                                paisDAO_EF.ListarPaisEF();
                                paisDAO_EF.ActualizarPaisEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            default:
                                break;
                        }

                        break;

                    case 4:
                        ViajeDAO viajeDAO = new ViajeDAO();
                        PaisDAO paisDAO_EF2 = new PaisDAO();
                        TarjetaDAO tarjDAO_EF2 = new TarjetaDAO();
                        Console.Clear();
                        Console.WriteLine("Mantenimiento Viaje");
                        Console.WriteLine("\n1 - Registrar Viaje");
                        Console.WriteLine("2 - Listar Viaje");                        
                        Console.WriteLine("\n Ingrese Opción: ");
                        int opcion4;
                        opcion4 = Convert.ToInt32(Console.ReadLine());
                        switch (opcion4)
                        {
                            case 1:
                                tarjDAO_EF2.ListarTarjetaEF();
                                paisDAO_EF2.ListarPaisEF();
                                ViajeBEAN viajeBEAN = new ViajeBEAN();

                                Console.WriteLine("Ingrese IdTarjeta:");
                                viajeBEAN.IdTarjeta = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese IdPais:");
                                viajeBEAN.IdPais = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese Fecha Inicio Viaje:");
                                viajeBEAN.FechaInicioViaje = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Ingrese Fecha Fin Viaje:");
                                viajeBEAN.FechaFinViaje = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Ingrese estado Viaje:");
                                viajeBEAN.EstadoViaje = Convert.ToString(Console.ReadLine());


                                bool rptaReg = viajeDAO.RegistrarRol(viajeBEAN);
                                if (rptaReg)
                                {
                                    Console.WriteLine("Registrado Correctado");
                                }
                                else
                                {
                                    Console.WriteLine("Error en registar de Viaje");
                                }
                                
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;

                            case 2:
                                List<ViajeBEAN> listaViaje = new List<ViajeBEAN>();
                                listaViaje = viajeDAO.ListarViaje();
                                Console.Clear();
                                Console.WriteLine("Lista Viajes");
                                foreach (var item in listaViaje)
                                {
                                    Console.WriteLine("IdViaje \t IdTarjeta \t IdPais \t FechaInicioViaje \t FechaFinViaje \t EstadoViaje");
                                    Console.WriteLine(item.IdViaje + "\t" + item.IdTarjeta + "\t" + item.IdPais + "\t" + item.FechaInicioViaje + "\t" + item.FechaFinViaje +"\t" + item.EstadoViaje);
                                }                                
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;                            
                            default:
                                break;
                        }

                        break;
                    default:
                        break;
                }

            } while (rpta == "S" || rpta == "s");
        }
    }
}
